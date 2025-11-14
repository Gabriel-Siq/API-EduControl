namespace API_EduControl.DTOs.Aluno
{
    public class CriarAlunoDTO
    {
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime DataNascimento { get; set; }
    }
}
