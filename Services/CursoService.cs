using API_EduControl.Data;
using API_EduControl.DTOs.Curso;
using API_EduControl.Interfaces;
using API_EduControl.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_EduControl.Services
{
    public class CursoService: ICursoService
    {
        private readonly EduControl _context;

        public CursoService(EduControl context)
        {
            _context = context;
        }

        public async Task<Curso?> CriarCursoAsync(CriarCursoDTO dto)
        {
            if (dto == null)
                return null;

            var curso = new Curso
            {
                Nome = dto.Nome,
                Descricao = dto.Descricao,
            };

            _context.Curso.Add(curso);
            await _context.SaveChangesAsync();

            return curso;
        }

        public async Task<List<Curso>> ListarCursosAsync()
        {
            var cursos = await _context.Curso.ToListAsync();
            return cursos;
        }

        public async Task<Curso?> AtualizarCursoAsync(int id, AtualizarCursoDTO cursoAtualizado)
        {
            var curso = await _context.Curso.FindAsync(id);

            if (curso == null)
                return null;

            curso.Nome = cursoAtualizado.Nome;
            curso.Descricao = cursoAtualizado.Descricao;

            await _context.SaveChangesAsync();

            return curso;
        }

        public async Task<Curso?> DeletarCursoAsync(int id)
        {
            var curso = await _context.Curso.FindAsync(id);
            if (curso == null)
                return null;

            _context.Curso.Remove(curso);
            await _context.SaveChangesAsync();

            return curso;
        }
    }
}
