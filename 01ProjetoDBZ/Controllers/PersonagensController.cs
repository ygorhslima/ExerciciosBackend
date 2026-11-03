using _01ProjetoDBZ.Data;
using _01ProjetoDBZ.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _01ProjetoDBZ.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PersonagensController : Controller
{
    private readonly AppDbContext _appDbContext;
    
    public PersonagensController(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    [HttpPost]
    public async Task<IActionResult> AddPersonagem(Personagem personagem)
    {
        _appDbContext.DBZ.Add(personagem);
        await _appDbContext.SaveChangesAsync();
        return Ok(personagem);
    }

    [HttpGet]
    public async Task<IEnumerable<Personagem>> GetPersonagem()
    {
        var result = await _appDbContext.DBZ.ToListAsync();
        return result;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Personagem>> GetPersonagemById(int id)
    {
        var personagem = await _appDbContext.DBZ.FindAsync(id);
        if(personagem == null)
        {
            return NotFound("Personagem não encontrado");
        }
        return Ok(personagem);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdatePersonagem(int id, [FromBody] Personagem personagemAtualizado)
    {
        var personagemExistente = await _appDbContext.DBZ.FindAsync(id);
        if(personagemExistente == null)
        {
            return NotFound("Personagem não encontrado");
        }
        // o que esta linha faz é substituir os dados existentes pelos dados novos
        _appDbContext.Entry(personagemExistente)
        .CurrentValues
        .SetValues(personagemAtualizado);

        await _appDbContext.SaveChangesAsync();
        return StatusCode(201, personagemExistente);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePersonagem(int id)
    {
        var personagem = await _appDbContext.DBZ.FindAsync(id);
        
        if(personagem == null)
        {
            return NotFound("Personagem não encontrado");
        }
        
        _appDbContext.DBZ.Remove(personagem);

        await _appDbContext.SaveChangesAsync();
        return Ok("Personagem deletado com sucesso");
    }
}
