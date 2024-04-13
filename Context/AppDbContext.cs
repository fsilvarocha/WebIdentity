using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebIdentity.Entities;
using WebIdentity.Models;

namespace WebIdentity.Context;

public class AppDbContext : IdentityDbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) :
        base(options)
    {

    }

    public DbSet<Aluno> Alunos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<RegisterViewModel>().HasNoKey();
        modelBuilder.Entity<LoginViewModel>().HasNoKey();   

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

public DbSet<WebIdentity.Models.RegisterViewModel> RegisterViewModel { get; set; } = default!;
}
