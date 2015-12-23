using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using Web.Models;

namespace Web.Migrations
{
    [DbContext(typeof(RecipeContext))]
    [Migration("20151223125355_ch_23212015_1553")]
    partial class ch_23212015_1553
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

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 255);

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
