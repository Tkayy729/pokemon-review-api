using AutoMapper;
using PokemonReviewApp.Dto;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Helpers;

public class MappingProfiles: Profile 
{
    public MappingProfiles()
    {
        CreateMap<Pokemon, PokemonDTO>();
        CreateMap<PokemonDTO, Pokemon>();
        CreateMap<OwnerDTO, Owner>();
        CreateMap<Country, CountryDTO>();
        CreateMap<CountryDTO, Country>();
        CreateMap<Category, CategoryDTO>();
        CreateMap<CategoryDTO, Category>();
        CreateMap<Review, ReviewDTO>();
        CreateMap<ReviewDTO, Review>();
        CreateMap<Reviewer, ReviewerDTO>();
        CreateMap<ReviewerDTO, Reviewer>();
    }
}