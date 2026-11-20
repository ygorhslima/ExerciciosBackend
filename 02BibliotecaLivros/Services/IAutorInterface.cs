using System;
using _02BibliotecaLivros.Models;

namespace _02BibliotecaLivros.Services;

/// <summary>
/// retorna todos os métodos relacionado aos autores que serão utilizados pelo service 
/// </summary>
public interface IAutorInterface
{
    Task<ResponseModel<List<AutorModel>>> ListarAutores();
    Task<ResponseModel<AutorModel>> BuscarAutorPorId(int idAutor);
    Task<ResponseModel<AutorModel>> BuscarAutorPorIdLivro(int idLivro);
}