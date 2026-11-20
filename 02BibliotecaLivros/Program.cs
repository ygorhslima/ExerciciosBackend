using _02BibliotecaLivros.Data;
using _02BibliotecaLivros.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddOpenApi();

builder.Services.AddDbContext<AppDbContext>(options =>
{
    // criando uma conexão com o banco de dados obtendo as informações que contém no connection string
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
});

//AddScoped = serve para reaproveitar o mesmo objeto enquanto uma mesma operação (geralmente uma requisição HTTP) está acontecendo, e jogar esse objeto fora assim que ela termina.

builder.Services.AddScoped<IAutorInterface, AutorService>();

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();