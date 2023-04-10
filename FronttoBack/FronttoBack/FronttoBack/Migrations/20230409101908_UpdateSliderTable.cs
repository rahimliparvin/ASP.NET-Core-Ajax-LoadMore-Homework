using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FronttoBack.Migrations
{
    public partial class UpdateSliderTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SliderId",
                table: "SliderInfos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SliderInfos_SliderId",
                table: "SliderInfos",
                column: "SliderId");

            migrationBuilder.AddForeignKey(
                name: "FK_SliderInfos_Sliders_SliderId",
                table: "SliderInfos",
                column: "SliderId",
                principalTable: "Sliders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SliderInfos_Sliders_SliderId",
                table: "SliderInfos");

            migrationBuilder.DropIndex(
                name: "IX_SliderInfos_SliderId",
                table: "SliderInfos");

            migrationBuilder.DropColumn(
                name: "SliderId",
                table: "SliderInfos");
        }
    }
}
