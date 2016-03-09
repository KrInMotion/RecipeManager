using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Data.Entity;
using Web.Models.Entities;

namespace Web.Models
{
    public static class SampleData
    {
        public static void Initialize(IServiceProvider service)
        {
            var context = service.GetService<RecipeContext>();
            context.Database.Migrate();
            //if (!context.Categories.Any())
            //{
            //    context.Categories.AddRange(
            //    new Category { Name = "Первые блюда" },
            //    new Category { Name = "Вторые блюда" },
            //    new Category { Name = "Закуски" },
            //    new Category { Name = "Салаты" },
            //    new Category { Name = "Торты" },
            //    new Category { Name = "Выпечка" },
            //    new Category { Name = "Гарниры" },
            //    new Category { Name = "Мясное" },
            //    new Category { Name = "Овощное" },
            //    new Category { Name = "Завтрак" });
            //    context.SaveChanges();
            //}
        }
    }
}
