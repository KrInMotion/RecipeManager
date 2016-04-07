using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models.Entities;

namespace Web.Models.Repositories
{
    public class RecipeRepository : IRecipeRepository
    {
        private readonly RecipeContext _context;

        public RecipeRepository(RecipeContext context)
        {
            _context = context;
        }

        public IEnumerable<Recipe> FindRecipe(string searchText)
        {
            var result = _context.Recipies
                .Include(x => x.Category)
                .Where(x=>x.Title.Contains(searchText) || x.Category.Name.Contains(searchText))
                .ToList();
            return result;
        }

        public IEnumerable<Recipe> GetAllRecipes()
        {
            return _context.Recipies.ToList();
        }

        public IEnumerable<Recipe> GetAllRecipesWithCategory()
        {
            return _context.Recipies.Include(x=>x.Category).ToList();
        }
        public void CreateRecipe(Recipe entity)
        {
            _context.Recipies.Add(entity);
        }

        public bool Commit()
        {
            return _context.SaveChanges() > 0;
        }

        public Recipe GetRecipe(int id)
        {
            return _context.Recipies.Include(x=>x.Category).FirstOrDefault(x => x.Id == id);
        }

        public void DeleteRecipe(Recipe entity)
        {
            _context.Recipies.Remove(entity);
        }
    }
}
