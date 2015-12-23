using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models.Entities;

namespace Web.Models.Repositories
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories();
        IEnumerable<Category> GetAllCategoriesWithRecipe();
        bool SaveAll();
    }
}
