using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.ViewModels.Recipe
{
    public class RecipeDetailVM
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        [Display(Name = "Категория")]
        public string CategoryName { get; set; }
        [Display(Name ="Наименование")]
        public string Title { get; set; }
        [Display(Name = "Приготовление блюда"), DataType(DataType.MultilineText)]
        public string Content { get; set; }
        [Display(Name = "Время приготовления")]
        public string CoockTime { get; set; }
        [Display(Name = "Количество порций")]
        public int Portions { get; set; }
        [Display(Name = "Дата публикации")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d MMMM yyyy}", ApplyFormatInEditMode = false)]
        public DateTime CreatedAt { get; set; }
        [Display(Name = "Дата обновления")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d MMMM yyyy}", ApplyFormatInEditMode = false)]
        public DateTime? UpdatedAt { get; set; }
    }
}
