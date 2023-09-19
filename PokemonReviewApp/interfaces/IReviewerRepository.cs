using PokemonReviewApp.Models;

namespace PokemonReviewApp.interfaces;

public interface IReviewerRepository
{
    ICollection<Reviewer> getReviewerswers();
    Reviewer GetReviewer(int id);
    bool ReviewerExists(int reviwerId);
}