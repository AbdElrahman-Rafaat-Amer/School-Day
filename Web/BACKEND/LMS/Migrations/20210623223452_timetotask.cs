using Microsoft.EntityFrameworkCore.Migrations;

namespace LMS.Migrations
{
    public partial class timetotask : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "GivenDegree",
                table: "Tasks",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "TimeForExam",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GivenDegree",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "TimeForExam",
                table: "Tasks");
        }
    }
}
