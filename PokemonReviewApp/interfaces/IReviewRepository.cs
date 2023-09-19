using PokemonReviewApp.Models;

namespace PokemonReviewApp.interfaces;

public interface IReviewRepository
{
    ICollection<Review> getReviews();
    Review getReview(int id);
    bool ReviewExists(int reviewId);
}