namespace API_EduControl.Models
{
    public class Aluno
    {
        public int AlunoId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime? DataNascimento { get; set; }

        public ICollection<Matricula>? Matriculas { get; set; }

    }
}
