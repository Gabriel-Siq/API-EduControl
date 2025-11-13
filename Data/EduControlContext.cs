using API_EduControl.Models;
using Microsoft.EntityFrameworkCore;

namespace API_EduControl.Data
{
    public class EduControl : DbContext
    {
        public EduControl(DbContextOptions<EduControl> options) : base(options) { }

        public DbSet<Aluno> Aluno => Set<Aluno>();
        public DbSet<Curso> Curso => Set<Curso>();
    }
}
