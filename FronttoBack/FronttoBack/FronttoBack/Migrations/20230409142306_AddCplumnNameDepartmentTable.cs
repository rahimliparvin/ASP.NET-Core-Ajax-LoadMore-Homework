using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FronttoBack.Migrations
{
    public partial class AddCplumnNameDepartmentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Departments",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Departments");
        }
    }
}
