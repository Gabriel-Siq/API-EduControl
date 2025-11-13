namespace API_EduControl.Models
{
    public class Curso
    {
        public int CursoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; } = null!;


        public List<Aluno>? Alunos { get; set; }
    }
}
