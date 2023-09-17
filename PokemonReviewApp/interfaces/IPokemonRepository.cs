using PokemonReviewApp.Models;

namespace PokemonReviewApp.interfaces;

public interface IPokemonRepository
{
    ICollection<Pokemon> GetPokemons();
}