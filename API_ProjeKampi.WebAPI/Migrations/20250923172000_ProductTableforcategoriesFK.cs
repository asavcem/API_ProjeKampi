using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_ProjeKampi.WebAPI.Migrations
{
    public partial class ProductTableforcategoriesFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductID",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ProductID",
                table: "Categories",
                column: "ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Products_ProductID",
                table: "Categories",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Products_ProductID",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_ProductID",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductID",
                table: "Categories");
        }
    }
}
