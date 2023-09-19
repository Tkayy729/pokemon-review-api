using PokemonReviewApp.interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.repositories;

public class ReviewerRepository : IReviewerRepository
{
    public ReviewerRepository()
    {
    }

    public ICollection<Reviewer> getReviewerswers()
    {
        throw new NotImplementedException();
    }

    public Reviewer GetReviewer(int id)
    {
        throw new NotImplementedException();
    }

    public bool ReviewerExists(int reviwerId)
    {
        throw new NotImplementedException();
    }
}