using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models.Entities;

namespace Web.Models.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly RecipeContext _context;

        public CategoryRepository(RecipeContext context)
        {
            _context = context;
        }
        public IEnumerable<Category> GetAllCategories()
        {
            return _context.Categories.ToList();
        }

        public IEnumerable<Category> GetAllCategoriesWithRecipe()
        {
            return _context.Categories.Include(x=>x.Recipies);
        }
        public bool SaveAll()
        {
            return _context.SaveChanges() > 0;
        }

    }
}
