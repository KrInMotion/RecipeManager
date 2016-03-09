using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.ViewModels.Recipe
{
    public class RecipeListVM
    {
        public int Id { get; set; }
        [Display(Name = "Наименование")]
        public string Title { get; set; }
        public int CategoryId { get; set; }
        [Display(Name = "Категория")]
        public string CategoryName { get; set; }
    }
}
