using Microsoft.EntityFrameworkCore;
using SC.API.Domain;

namespace Api.Data
{
    public class MainContext : DbContext
    {
        public MainContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Presenca>(
                p =>
                {
                    p.HasNoKey();
                });
        }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Presenca> Registro_Presenca { get; set; }
        public DbSet<Situacao> Situacao { get; set; }
        public DbSet<Turma> Turmas { get; set; }
    }
}
