using System;

namespace _02BibliotecaLivros.Models;

/// <summary>
/// Esta classe cria uma padronização de respostas na api
/// </summary>
/// <typeparam name="T">é um parâmetro genérico que pode ser passado qualquer tipo de dados</typeparam>
public class ResponseModel<T>
{
    public T? Dados { get; set; }
    public string Mensagem { get; set; } = string.Empty;
    public bool Status { get; set; } = true;
}
