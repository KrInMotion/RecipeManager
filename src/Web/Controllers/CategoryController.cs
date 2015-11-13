using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Web.ViewModels.Category;

namespace Web.Controllers
{
    public class CategoryController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var model = new List<CategoryListVM>
            {
                new CategoryListVM {Id=1, CategoryName="Категория №1", RecipeCount=0 },
                new CategoryListVM {Id=2, CategoryName="Категория №2", RecipeCount=10, DeleteClass="disabled" },
                new CategoryListVM {Id=3, CategoryName="Категория №3", RecipeCount=4, DeleteClass="disabled" },
                new CategoryListVM {Id=4, CategoryName="Категория №4", RecipeCount=6, DeleteClass="disabled" },
                new CategoryListVM {Id=5, CategoryName="Категория №5", RecipeCount=0 }
            };
            return View(model);
        }

        public IActionResult Edit(int id)
        {
            return View();
        }
    }
}
