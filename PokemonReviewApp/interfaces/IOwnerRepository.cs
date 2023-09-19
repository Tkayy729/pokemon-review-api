using PokemonReviewApp.Models;
using PokemonReviewApp.repositories;

namespace PokemonReviewApp.interfaces;

public interface IOwnerRepository
{
    ICollection<Owner> GetOwners();
    Owner GetOwner(int id);
    bool OwnerExists(int ownerId);
}