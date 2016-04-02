using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using Web.Models;

namespace Web.Migrations
{
    [DbContext(typeof(RecipeContext))]
    [Migration("20160402091550_v4")]
    partial class v4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Web.Models.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 255);

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Web.Models.Entities.Recipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryId");

                    b.Property<string>("Content")
                        .IsRequired();

                    b.Property<string>("CoockTime")
                        .HasAnnotation("MaxLength", 100);

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("Relational:GeneratedValueSql", "getdate()");

                    b.Property<bool>("IsFavorite");

                    b.Property<int>("Portions");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 255);

                    b.Property<DateTime?>("UpdatedAt");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Web.Models.Entities.Recipe", b =>
                {
                    b.HasOne("Web.Models.Entities.Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");
                });
        }
    }
}
