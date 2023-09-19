using PokemonReviewApp.Models;

namespace PokemonReviewApp.Dto;

public class OwnerDTO
{
    public int Id { get; set; }
    public string Firstname { get; set; }
		
    public string Lastname { get; set; }
    public string Gym { get; set; }
    public Country Country { get; set; }
}