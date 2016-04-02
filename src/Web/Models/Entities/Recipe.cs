using System;

namespace Web.Models.Entities
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public string Content { get; set; }
        public int Portions { get; set; }
        public string CoockTime { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool IsFavorite { get; set; }

    }
}