using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Web.ViewModels.Recipe;
using Microsoft.Extensions.Logging;
using Web.Models.Repositories;
using Web.Models.Entities;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Web.Controllers
{
    public class RecipeController : Controller
    {
        private readonly ILogger<RecipeController> _logger;
        private readonly IRecipeRepository _recipeRepository;

        public RecipeController(IRecipeRepository recipeRepository, ILogger<RecipeController> logger)
        {
            _recipeRepository = recipeRepository;
            _logger = logger;
        }
        public IActionResult Index()
        {
            var entity = _recipeRepository.GetAllRecipesWithCategory();
            var model = new List<RecipeListVM>();
            foreach (var item in entity)
            {
                model.Add(new RecipeListVM
                {
                    Id = item.Id,
                    CategoryId = item.CategoryId,
                    CategoryName = item.Category.Name,
                    Title = item.Title
                });
            };
            return View(model);
        }

        public IActionResult Detail(int id)
        {
            return View();
        }
    }
}
