using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Web.ViewModels.Recipe;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Web.Controllers
{
    public class RecipeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var model = new List<RecipeListVM>
            {new RecipeListVM {
                Id = 1,
                Title = "Тестовое наименование"
            }};
            return View(model);
        }
    }
}
