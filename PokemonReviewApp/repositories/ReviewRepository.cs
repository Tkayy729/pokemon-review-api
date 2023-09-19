using PokemonReviewApp.interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.repositories;

public class ReviewRepository : IReviewRepository
{
    public ReviewRepository()
    {
    }

    public ICollection<Review> getReviews()
    {
        throw new NotImplementedException();
    }

    public Review getReview(int id)
    {
        throw new NotImplementedException();
    }

    public bool ReviewExists(int reviewId)
    {
        throw new NotImplementedException();
    }
}