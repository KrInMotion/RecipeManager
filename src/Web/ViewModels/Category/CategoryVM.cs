using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.ViewModels.Category
{
    public class CategoryListVM
    {
        public int Id { get; set; }
        //[DisplayName("Наименование категории")]
        public string CategoryName { get; set; }
        //[DisplayName("Кол-во рецептов")]
        public int RecipeCount { get; set; }
        [ScaffoldColumn(false)]
        public string DeleteClass { get; set; }
    }
}
