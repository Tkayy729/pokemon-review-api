using Microsoft.AspNetCore.Mvc;
using PokemonReviewApp.interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PokemonController: Controller
{
    private readonly IPokemonRepository _iPokemonRepository;
    
    public PokemonController(IPokemonRepository pokemonRepository)
    {
        _iPokemonRepository = pokemonRepository;
    }

    [HttpGet]
    [ProducesResponseType(200, Type = typeof(IEnumerable<Pokemon>))]
    public IActionResult GetPokemons()
    {
        var pokemons = _iPokemonRepository.GetPokemons();

        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        return Ok(pokemons);
    }
}