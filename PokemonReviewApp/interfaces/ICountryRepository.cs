using PokemonReviewApp.Models;

namespace PokemonReviewApp.interfaces;

public interface ICountryRepository
{
    ICollection<Country> GetCountries();
    Country GetCountry(int id);
    bool CategoryExists(int countryId);
}