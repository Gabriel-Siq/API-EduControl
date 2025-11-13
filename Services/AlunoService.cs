using API_EduControl.Data;
using API_EduControl.DTOs.Aluno;
using API_EduControl.Interfaces;
using API_EduControl.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_EduControl.Services
{
    public class AlunoService: IAlunoService
    {
        private readonly EduControl _context;

        public AlunoService(EduControl context)
        {
            _context = context;
        }

        public async Task<Aluno?> CriarAlunoAsync(CriarAlunoDTO dto)
        {
            if (dto == null)
                return null;

            var aluno = new Aluno
            {
                Nome = dto.Nome,
                Email = dto.Email,
                DataNascimento = dto.DataNascimento,
                CursoId = dto.CursoId
            };

            _context.Aluno.Add(aluno);
            await _context.SaveChangesAsync();

            return aluno;
        }

        public async Task<List<Aluno>> ListarAlunosAsync()
        {
            var alunos = await _context.Aluno.ToListAsync();
            return alunos;
        }

        public async Task<Aluno?> AtualizarAlunoAsync(int id, AtualizarAlunoDTO alunoAtualizado)
        {
            var aluno = await _context.Aluno.FindAsync(id);

            if (aluno == null)
                return null;

            aluno.Nome = alunoAtualizado.Nome;
            aluno.Email = alunoAtualizado.Email;
            aluno.DataNascimento = alunoAtualizado.DataNascimento;
            aluno.CursoId = alunoAtualizado.CursoId;

            await _context.SaveChangesAsync();

            return aluno;
        }

        public async Task<Aluno?> DeletarAlunoAsync(int id)
        {
            var aluno = await _context.Aluno.FindAsync(id);
            if (aluno == null)
                return null;

            _context.Aluno.Remove(aluno);
            await _context.SaveChangesAsync();

            return aluno;
        }
    }
}
