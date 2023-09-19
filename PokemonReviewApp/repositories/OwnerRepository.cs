using Microsoft.AspNetCore.Mvc;
using PokemonReviewApp.Data;
using PokemonReviewApp.interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.repositories;
 
public class OwnerRepository : IOwnerRepository
{
    private readonly ApplicationDbContext _context;
    
    public OwnerRepository(ApplicationDbContext context)
    {
        _context = context;
    }


    public ICollection<Owner> GetOwners()
    {
        return _context.Owners.OrderBy(o => o.Id).ToList();
    }

    public Owner GetOwner(int id)
    {
        return _context.Owners.Where(o => o.Id == id).FirstOrDefault();
    }

    public bool OwnerExists(int ownerId)
    {
        return _context.Owners.Any(o => o.Id == ownerId);
    }
}