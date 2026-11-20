namespace _02BibliotecaLivros.Models;

public class LivroModel
{
    public int Id { get; set; }
    public string ?Titulo { get; set; }

    // um livro pode ser um autor em específico
    public AutorModel Autor {get;set;}
}
