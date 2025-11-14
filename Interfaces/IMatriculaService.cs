using API_EduControl.DTOs.Matricula;
using API_EduControl.Models;

namespace API_EduControl.Interfaces
{
    public interface IMatriculaService
    {
        Task<Matricula?> CriarMatriculaAsync(CriarMatriculaDTO matricula);
        Task<Matricula?> DeletarMatriculaAsync(int alunoId, int cursoId);
        Task<List<Matricula>> ListarMatriculasAsync();
    }
}
