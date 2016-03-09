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
        public IEnumerable<Recipe> GetAllRecipes()
        {
            return _context.Recipies.ToList();
        }

        public IEnumerable<Recipe> GetAllRecipesWithCategory()
        {
            return _context.Recipies.Include(x=>x.Category).ToList();
        }

        public bool SaveAll()
        {
            return _context.SaveChanges() > 0;
        }

    }
}
