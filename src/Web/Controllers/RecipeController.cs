using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Web.ViewModels.Recipe;
using Microsoft.Extensions.Logging;
using Web.Models.Repositories;
using Web.Models.Entities;

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
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Search(string searchText)
        {
            if (string.IsNullOrEmpty(searchText))
                return RedirectToAction("Index");
            var entity = _recipeRepository.FindRecipe(searchText);
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

        [HttpGet]
        public IActionResult Create()
        {
            var model = new RecipeFormVM();
            return View(model);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Create(RecipeFormVM model)
        {
            var entity = new Recipe
            {
                Title=model.Title,
                CoockTime=model.CoockTime,
                Content=model.Content
            };
            entity.CreatedAt = DateTime.Now;
            return RedirectToAction("Detail", new { id = entity.Id });
        }

        public IActionResult Detail(int id)
        {
            return View();
        }
    }
}
