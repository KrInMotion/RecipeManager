using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models.Entities;

namespace Web.Models
{
    public class RecipeContext: DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Recipe> Recipies { get; set; }

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(255);
            modelBuilder.Entity<Recipe>()
                .Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(255);
        }
    }
}
