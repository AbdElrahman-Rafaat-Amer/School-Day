using Microsoft.EntityFrameworkCore.Migrations;

namespace LMS.Migrations
{
    public partial class addre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "YearId",
                table: "Tasks",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_YearId",
                table: "Tasks",
                column: "YearId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Years_YearId",
                table: "Tasks",
                column: "YearId",
                principalTable: "Years",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Years_YearId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_YearId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "YearId",
                table: "Tasks");
        }
    }
}
