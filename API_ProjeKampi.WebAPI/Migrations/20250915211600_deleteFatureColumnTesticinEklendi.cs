using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_ProjeKampi.WebAPI.Migrations
{
    public partial class deleteFatureColumnTesticinEklendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TestIcınEklendi",
                table: "Features");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TestIcınEklendi",
                table: "Features",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
