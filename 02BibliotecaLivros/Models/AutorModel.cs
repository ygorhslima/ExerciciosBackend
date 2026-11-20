namespace _02BibliotecaLivros.Models;

public class AutorModel
{
    public int Id { get; set; }
    public string ?Nome { get; set; }
    public string ?Sobrenome { get; set; }

    // um autor pode ter criado vários livros, então para isso, é preciso criar uma lista de livros
    public ICollection<LivroModel> ?Livros { get; set; }
}
