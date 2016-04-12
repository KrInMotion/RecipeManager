using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.ViewModels.Recipe
{
    public class RecipeFormVM
    {
        public int Id { get; set; }
        [Display(Name = "Категория *"), Required]
        public int CategoryId { get; set; }
        [Display(Name ="Наименование *"), Required, MaxLength(255)]
        public string Title { get; set; }
        [Display(Name = "Приготовление блюда *"), Required, DataType(DataType.MultilineText)]
        public string Content { get; set; }
        [Display(Name = "Время приготовления *"), Required, MaxLength(100)]
        public string CoockTime { get; set; }
        [Display(Name = "Количество порций"), Range(0, 100)]
        public int Portions { get; set; }
    }
}
