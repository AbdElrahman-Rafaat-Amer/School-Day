using Microsoft.EntityFrameworkCore.Migrations;

namespace LMS.Migrations
{
    public partial class yearupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "YearId",
                table: "Chapters",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Chapters_YearId",
                table: "Chapters",
                column: "YearId");

            migrationBuilder.AddForeignKey(
                name: "FK_Chapters_Years_YearId",
                table: "Chapters",
                column: "YearId",
                principalTable: "Years",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chapters_Years_YearId",
                table: "Chapters");

            migrationBuilder.DropIndex(
                name: "IX_Chapters_YearId",
                table: "Chapters");

            migrationBuilder.DropColumn(
                name: "YearId",
                table: "Chapters");
        }
    }
}
