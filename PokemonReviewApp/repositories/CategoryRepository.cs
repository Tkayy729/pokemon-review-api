using PokemonReviewApp.Data;
using PokemonReviewApp.interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.repositories;

public class CategoryRepository: ICategoryRepository
{
    private readonly ApplicationDbContext _dbContext;
    
    public CategoryRepository(ApplicationDbContext context)
    {
        _dbContext = context;
    }

    public ICollection<Category> GetCategories()
    {
      return _dbContext.Categories.OrderBy(c => c.Id).ToList();
    }

    public Category GetCategory(int id)
    {
        return _dbContext.Categories.Where(c => c.Id == id).FirstOrDefault();
    }

    public ICollection<Pokemon> GetPokemonByCategory(int categoryId)
    {
        return _dbContext.PokemonCategories.Where(pc => pc.CategoryId == categoryId).Select(pc => pc.Pokemon).ToList();
    }

    public bool CategoryExists(int categoryId)
    {
        return _dbContext.Categories.Any(p => p.Id == categoryId);
    }

    public bool CreateCategory(Category category)
    {
        _dbContext.Add(category);
        return Save();
    }

    public bool UpdateCategory(Category category)
    {
        _dbContext.Update(category);
        return Save();
    }

    public bool DeleteCategory(Category category)
    {
        _dbContext.Categories.Remove(category);
        return Save();
    }

    public bool Save()
    {
        var saved = _dbContext.SaveChanges();
        return saved > 0 ? true : false;
    }
}