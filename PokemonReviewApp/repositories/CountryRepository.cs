using PokemonReviewApp.interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.repositories;

public class CountryRepository : ICountryRepository
{
    public CountryRepository()
    {
    }

    public ICollection<Country> GetCountries()
    {
        throw new NotImplementedException();
    }

    public Country GetCountry(int id)
    {
        throw new NotImplementedException();
    }

    public bool CategoryExists(int countryId)
    {
        throw new NotImplementedException();
    }
}