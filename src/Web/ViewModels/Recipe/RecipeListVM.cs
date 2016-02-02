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
        [Display(Name = "Дата создании")]
        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; }
        [Display(Name = "Дата обновления")]
        [DataType(DataType.Date)]
        public DateTime? UpdatedAt { get; set; }
        public int CategoryId { get; set; }
        [Display(Name = "Наименование категории")]
        public string CategoryName { get; set; }
    }
}
