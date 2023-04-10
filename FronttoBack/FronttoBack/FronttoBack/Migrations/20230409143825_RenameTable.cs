using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FronttoBack.Migrations
{
    public partial class RenameTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_DepartmentsCategories_CompanyDepartmentId",
                table: "Departments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DepartmentsCategories",
                table: "DepartmentsCategories");

            migrationBuilder.RenameTable(
                name: "DepartmentsCategories",
                newName: "CompanyDepartments");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CompanyDepartments",
                table: "CompanyDepartments",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_CompanyDepartments_CompanyDepartmentId",
                table: "Departments",
                column: "CompanyDepartmentId",
                principalTable: "CompanyDepartments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_CompanyDepartments_CompanyDepartmentId",
                table: "Departments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CompanyDepartments",
                table: "CompanyDepartments");

            migrationBuilder.RenameTable(
                name: "CompanyDepartments",
                newName: "DepartmentsCategories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DepartmentsCategories",
                table: "DepartmentsCategories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_DepartmentsCategories_CompanyDepartmentId",
                table: "Departments",
                column: "CompanyDepartmentId",
                principalTable: "DepartmentsCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
