using API_EduControl.DTOs.Curso;
using API_EduControl.Models;

namespace API_EduControl.Interfaces
{
    public interface ICursoService
    {
        Task<Curso?> CriarCursoAsync(CriarCursoDTO curso);
        Task<List<Curso>> ListarCursosAsync();
        Task<Curso?> AtualizarCursoAsync(int id, AtualizarCursoDTO cursoAtualizado);
        Task <Curso?> DeletarCursoAsync(int id);
    }
}
