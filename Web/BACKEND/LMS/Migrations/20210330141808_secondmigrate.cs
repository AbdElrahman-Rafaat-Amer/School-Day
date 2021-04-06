using Microsoft.EntityFrameworkCore.Migrations;

namespace LMS.Migrations
{
    public partial class secondmigrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Years_Teachers_TeacherId",
                table: "Years");

            migrationBuilder.DropIndex(
                name: "IX_Years_TeacherId",
                table: "Years");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "Years");

            migrationBuilder.AddColumn<int>(
                name: "ClassId",
                table: "Sections",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "YearId",
                table: "Classes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TeacherYear",
                columns: table => new
                {
                    TeachersId = table.Column<int>(type: "int", nullable: false),
                    YearsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherYear", x => new { x.TeachersId, x.YearsId });
                    table.ForeignKey(
                        name: "FK_TeacherYear_Teachers_TeachersId",
                        column: x => x.TeachersId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeacherYear_Years_YearsId",
                        column: x => x.YearsId,
                        principalTable: "Years",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sections_ClassId",
                table: "Sections",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_YearId",
                table: "Classes",
                column: "YearId");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherYear_YearsId",
                table: "TeacherYear",
                column: "YearsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Years_YearId",
                table: "Classes",
                column: "YearId",
                principalTable: "Years",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sections_Classes_ClassId",
                table: "Sections",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Years_YearId",
                table: "Classes");

            migrationBuilder.DropForeignKey(
                name: "FK_Sections_Classes_ClassId",
                table: "Sections");

            migrationBuilder.DropTable(
                name: "TeacherYear");

            migrationBuilder.DropIndex(
                name: "IX_Sections_ClassId",
                table: "Sections");

            migrationBuilder.DropIndex(
                name: "IX_Classes_YearId",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "ClassId",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "YearId",
                table: "Classes");

            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "Years",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Years_TeacherId",
                table: "Years",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Years_Teachers_TeacherId",
                table: "Years",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
