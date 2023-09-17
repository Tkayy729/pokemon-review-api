using PokemonReviewApp.Data;
using PokemonReviewApp.interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.repositories;

public class PokemonRepository : IPokemonRepository
{
    private readonly ApplicationDbContext _context;
    
    public PokemonRepository(ApplicationDbContext dbContext)
    {
        _context = dbContext;
    }

    public ICollection<Pokemon> GetPokemons()
    {
        return _context.Pokemon.OrderBy(p => p.Id).ToList();
    }
}