using System;
using System.ComponentModel.DataAnnotations;

namespace _01ProjetoDBZ.Models;
public class Personagem
{
    [Key]
    public int Id {get;set;}
    public string Nome { get; set; }
    public string Tipo { get; set; }
    
}