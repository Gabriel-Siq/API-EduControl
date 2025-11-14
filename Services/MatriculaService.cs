using API_EduControl.Data;
using API_EduControl.DTOs.Matricula;
using API_EduControl.Interfaces;
using API_EduControl.Models;
using Microsoft.EntityFrameworkCore;

namespace API_EduControl.Services
{
    public class MatriculaService: IMatriculaService
    {
        private readonly EduControl _context;

        public MatriculaService(EduControl context)
        {
            _context = context;
        }

        public async Task<List<Matricula>> ListarMatriculasAsync()
        {
            var matriculas = await _context.Matriculas.ToListAsync();
            return matriculas;
        }

        public async Task<Matricula> CriarMatriculaAsync(CriarMatriculaDTO dto)
        {
            if (dto.CursoId == 0 || dto.AlunoId == 0)
                throw new ArgumentException("Aluno e/ou curso não informados.");

            var existe = await _context.Matriculas
                .AnyAsync(m => m.AlunoId == dto.AlunoId && m.CursoId == dto.CursoId);

            if (existe)
                throw new InvalidOperationException("O aluno já está matriculado neste curso.");

            var matricula = new Matricula
            {
                CursoId = dto.CursoId,
                AlunoId = dto.AlunoId
            };

            _context.Matriculas.Add(matricula);
            await _context.SaveChangesAsync();

            return matricula;
        }

        public async Task<Matricula?> DeletarMatriculaAsync(int alunoId, int cursoId)
        {
            var matricula = await _context.Matriculas
                .FirstOrDefaultAsync(m => m.AlunoId == alunoId && m.CursoId == cursoId);
            
            if (matricula == null)
                return null;

            _context.Matriculas.Remove(matricula);
            await _context.SaveChangesAsync();

            return matricula;
        }
    }
}
