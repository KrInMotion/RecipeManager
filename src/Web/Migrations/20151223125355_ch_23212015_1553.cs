using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Web.Migrations
{
    public partial class ch_23212015_1553 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Recipe_Category_CategoryId", table: "Recipe");
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Recipe",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Category",
                nullable: false);
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
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Recipe",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Category",
                nullable: true);
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
