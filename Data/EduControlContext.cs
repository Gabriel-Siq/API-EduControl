using API_EduControl.Models;
using Microsoft.EntityFrameworkCore;

namespace API_EduControl.Data
{
    public class EduControl : DbContext
    {
        public EduControl(DbContextOptions<EduControl> options) : base(options) { }

        public DbSet<Aluno> Aluno => Set<Aluno>();
        public DbSet<Curso> Curso => Set<Curso>();
        public DbSet<Matricula> Matriculas => Set<Matricula>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Matricula>()
                .HasOne(m => m.Aluno)
                .WithMany(a => a.Matriculas)
                .HasForeignKey(m => m.AlunoId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Matricula>()
                .HasOne(m => m.Curso)
                .WithMany(c => c.Matriculas)
                .HasForeignKey(m => m.CursoId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
