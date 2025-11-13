using API_EduControl.DTOs.Aluno;
using API_EduControl.Models;

namespace API_EduControl.Interfaces
{
    public interface IAlunoService
    {
        Task<Aluno?> CriarAlunoAsync(CriarAlunoDTO aluno);
        Task<List<Aluno>> ListarAlunosAsync();
        Task<Aluno?> AtualizarAlunoAsync(int id, AtualizarAlunoDTO alunoAtualizado);
        Task <Aluno?> DeletarAlunoAsync(int id);
    }
}
