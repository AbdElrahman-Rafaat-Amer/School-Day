using Microsoft.EntityFrameworkCore.Migrations;

namespace LMS.Migrations
{
    public partial class addchapterColmuns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "YearId",
                table: "Subjects",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_YearId",
                table: "Subjects",
                column: "YearId");

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Years_YearId",
                table: "Subjects",
                column: "YearId",
                principalTable: "Years",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Years_YearId",
                table: "Subjects");

            migrationBuilder.DropIndex(
                name: "IX_Subjects_YearId",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "YearId",
                table: "Subjects");
        }
    }
}
