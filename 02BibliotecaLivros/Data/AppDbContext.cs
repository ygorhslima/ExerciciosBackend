using _02BibliotecaLivros.Models;
using Microsoft.EntityFrameworkCore;

namespace _02BibliotecaLivros.Data;

public class AppDbContext : DbContext
{
    // recebendo informações de conexão
    public AppDbContext(DbContextOptions<AppDbContext> options): base(options){}

    // criando as tabelas
    public DbSet<AutorModel> Autores {get;set;}
    public DbSet<LivroModel> Livros {get;set;}
}
