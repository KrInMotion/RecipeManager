namespace Web.Models.Entities
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

    }
}