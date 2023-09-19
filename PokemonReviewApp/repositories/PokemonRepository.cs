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
    public Pokemon GetPokemon(int id)
    {
        return _context.Pokemon.Where(p => p.Id == id).FirstOrDefault();
    }

    public Pokemon GetPokemon(string name)
    {
        return _context.Pokemon.Where(p => p.Name == name).FirstOrDefault();
    }

    public decimal GetPokemonRating(int pokeId)
    {
        var review = _context.Reviews.Where(r => r.Pokemon.Id == pokeId);
        if (review.Count() <= 0)
        {
            return 0;
        }
        return (decimal) review.Sum(r => r.Rating)/ review.Count();
    }

    public bool PokemonExists(int pokeId)
    {
       return _context.Pokemon.Any(p => p.Id == pokeId);
    }
}