using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Web.Migrations
{
    public partial class Recipe_02022016_1245 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Recipe_Category_CategoryId", table: "Recipe");
            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "Recipe",
                nullable: false,
                defaultValue: "");
            migrationBuilder.AddColumn<string>(
                name: "CoockTime",
                table: "Recipe",
                nullable: true);
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Recipe",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
            migrationBuilder.AddColumn<bool>(
                name: "IsFavorite",
                table: "Recipe",
                nullable: false,
                defaultValue: false);
            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Recipe",
                nullable: true);
            migrationBuilder.AddForeignKey(
                name: "FK_Recipe_Category_CategoryId",
                table: "Recipe",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Recipe_Category_CategoryId", table: "Recipe");
            migrationBuilder.DropColumn(name: "Content", table: "Recipe");
            migrationBuilder.DropColumn(name: "CoockTime", table: "Recipe");
            migrationBuilder.DropColumn(name: "CreatedAt", table: "Recipe");
            migrationBuilder.DropColumn(name: "IsFavorite", table: "Recipe");
            migrationBuilder.DropColumn(name: "UpdatedAt", table: "Recipe");
            migrationBuilder.AddForeignKey(
                name: "FK_Recipe_Category_CategoryId",
                table: "Recipe",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
