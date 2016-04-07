using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Web.ViewModels.Recipe;
using Microsoft.Extensions.Logging;
using Web.Models.Repositories;
using Web.Models.Entities;
using Microsoft.AspNet.Mvc.Rendering;

namespace Web.Controllers
{
    public class RecipeController : Controller
    {
        private readonly ILogger<RecipeController> _logger;
        private readonly IRecipeRepository _recipeRepository;
        private readonly ICategoryRepository _categoryRepository;

        public RecipeController(IRecipeRepository recipeRepository, 
            ICategoryRepository categoryRepository, 
            ILogger<RecipeController> logger)
        {
            _recipeRepository = recipeRepository;
            _categoryRepository = categoryRepository;
            _logger = logger;
        }

        //GET: Recipe/Index
        public IActionResult Index()
        {
            return View();
        }

        //POST: Recipe/Search/{searchText}
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
                    Title = item.Title,
                    SearchText = searchText
                });
            };
            return View(model);
        }

        //GET: Recipe/Create
        [HttpGet]
        public IActionResult Create()
        {
            var model = new RecipeFormVM
            {
                Portions = 1
            };
            ViewBag.Categories = new SelectList(_categoryRepository.GetAllCategories(), "Id", "Name");
            return View(model);
        }

        //POST: Recipe/Create
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Create(RecipeFormVM model)
        {
            if (ModelState.IsValid)
            {
                var entity = new Recipe
                {
                    CategoryId = model.CategoryId,
                    Title = model.Title,
                    CoockTime = model.CoockTime,
                    Content = model.Content,
                    Portions = model.Portions
                };
                entity.CreatedAt = DateTime.Now;
                return RedirectToAction("Detail", new { id = entity.Id });
            }
            ViewBag.Categories = new SelectList(_categoryRepository.GetAllCategories(), "Id", "Name");
            return View(model);
        }

        //GET: Recipe/Detail/{id}
        public IActionResult Detail(int id)
        {
            var entity = _recipeRepository.GetRecipe(id);
            if (entity == null)
            {
                return HttpNotFound();
            }
            var model = new RecipeDetailVM
            {
                Id = entity.Id,
                CategoryId = entity.CategoryId,
                CategoryName = entity.Category.Name,
                Title = entity.Title,
                Content = entity.Content,
                CoockTime = entity.CoockTime,
                Portions = entity.Portions,
                CreatedAt = entity.CreatedAt,
                UpdatedAt = entity.UpdatedAt
            };
            return View(model);
        }

        //POST: Recipe/Delete
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Delete(int selectedId, string searchText)
        {
            var entity = _recipeRepository.GetRecipe(selectedId);
            if(entity!=null)
            {
                _recipeRepository.DeleteRecipe(entity);
                _recipeRepository.Commit();
            }
            return RedirectToAction("Index");
        }
    }
}
