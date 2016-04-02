using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Web.Migrations
{
    public partial class v4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Recipe_Category_CategoryId", table: "Recipe");
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Recipe",
                nullable: false,
                defaultValueSql: "getdate()");
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
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Recipe",
                nullable: false);
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
