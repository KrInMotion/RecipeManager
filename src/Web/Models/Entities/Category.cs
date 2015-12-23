using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models.Entities
{
    public class Category
    {
        public Category()
        {
            Recipies = new List<Recipe>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Recipe> Recipies { get; set; }

    }
}
