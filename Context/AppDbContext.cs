using Microsoft.EntityFrameworkCore;
using WebIdentity.Entities;

namespace WebIdentity.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) :
        base(options)
    {

    }

    public DbSet<Aluno> Alunos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Aluno>().HasData(
            new Aluno
            {
                Id = 1,
                Nome = "Fabricio",
                Email = "fsilvarocha@gmail.com",
                Idade = 23,
                Curso = "Tecnologia"
            });
    }
}
