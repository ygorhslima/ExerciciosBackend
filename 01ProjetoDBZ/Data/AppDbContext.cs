using _01ProjetoDBZ.Models;
using Microsoft.EntityFrameworkCore;

namespace _01ProjetoDBZ.Data;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options){}

    // criando o schema
    public DbSet<Personagem> DBZ {get;set;}
     
}
