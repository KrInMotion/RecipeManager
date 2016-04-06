using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models.Entities;

namespace Web.Models.Repositories
{
    public interface IRecipeRepository
    {
        IEnumerable<Recipe> GetAllRecipes();
        IEnumerable<Recipe> GetAllRecipesWithCategory();
        IEnumerable<Recipe> FindRecipe(string searchText);
        Recipe GetRecipe(int id);
        bool Commit();
        void DeleteRecipe(Recipe entity);
    }
}
