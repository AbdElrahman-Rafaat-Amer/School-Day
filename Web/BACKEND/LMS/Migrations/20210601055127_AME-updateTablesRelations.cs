using Microsoft.EntityFrameworkCore.Migrations;

namespace LMS.Migrations
{
    public partial class AMEupdateTablesRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentAccountId",
                table: "Zooms",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GroupId",
                table: "Post",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentAccountId",
                table: "Post",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentAccountId",
                table: "NoteBoards",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentAccountId",
                table: "Groups",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentAccountId",
                table: "Fees",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentAccountId",
                table: "Attendances",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentAccountId",
                table: "Activities",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AccountGroup",
                columns: table => new
                {
                    GroupsId = table.Column<int>(type: "int", nullable: false),
                    membersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountGroup", x => new { x.GroupsId, x.membersId });
                    table.ForeignKey(
                        name: "FK_AccountGroup_Accounts_membersId",
                        column: x => x.membersId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccountGroup_Groups_GroupsId",
                        column: x => x.GroupsId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Zooms_StudentAccountId",
                table: "Zooms",
                column: "StudentAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Post_GroupId",
                table: "Post",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Post_StudentAccountId",
                table: "Post",
                column: "StudentAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_NoteBoards_StudentAccountId",
                table: "NoteBoards",
                column: "StudentAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_StudentAccountId",
                table: "Groups",
                column: "StudentAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Fees_StudentAccountId",
                table: "Fees",
                column: "StudentAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_StudentAccountId",
                table: "Attendances",
                column: "StudentAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Activities_StudentAccountId",
                table: "Activities",
                column: "StudentAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountGroup_membersId",
                table: "AccountGroup",
                column: "membersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Activities_Students_StudentAccountId",
                table: "Activities",
                column: "StudentAccountId",
                principalTable: "Students",
                principalColumn: "AccountId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Attendances_Students_StudentAccountId",
                table: "Attendances",
                column: "StudentAccountId",
                principalTable: "Students",
                principalColumn: "AccountId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Fees_Students_StudentAccountId",
                table: "Fees",
                column: "StudentAccountId",
                principalTable: "Students",
                principalColumn: "AccountId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Students_StudentAccountId",
                table: "Groups",
                column: "StudentAccountId",
                principalTable: "Students",
                principalColumn: "AccountId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NoteBoards_Students_StudentAccountId",
                table: "NoteBoards",
                column: "StudentAccountId",
                principalTable: "Students",
                principalColumn: "AccountId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Post_Groups_GroupId",
                table: "Post",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Post_Students_StudentAccountId",
                table: "Post",
                column: "StudentAccountId",
                principalTable: "Students",
                principalColumn: "AccountId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Zooms_Students_StudentAccountId",
                table: "Zooms",
                column: "StudentAccountId",
                principalTable: "Students",
                principalColumn: "AccountId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activities_Students_StudentAccountId",
                table: "Activities");

            migrationBuilder.DropForeignKey(
                name: "FK_Attendances_Students_StudentAccountId",
                table: "Attendances");

            migrationBuilder.DropForeignKey(
                name: "FK_Fees_Students_StudentAccountId",
                table: "Fees");

            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Students_StudentAccountId",
                table: "Groups");

            migrationBuilder.DropForeignKey(
                name: "FK_NoteBoards_Students_StudentAccountId",
                table: "NoteBoards");

            migrationBuilder.DropForeignKey(
                name: "FK_Post_Groups_GroupId",
                table: "Post");

            migrationBuilder.DropForeignKey(
                name: "FK_Post_Students_StudentAccountId",
                table: "Post");

            migrationBuilder.DropForeignKey(
                name: "FK_Zooms_Students_StudentAccountId",
                table: "Zooms");

            migrationBuilder.DropTable(
                name: "AccountGroup");

            migrationBuilder.DropIndex(
                name: "IX_Zooms_StudentAccountId",
                table: "Zooms");

            migrationBuilder.DropIndex(
                name: "IX_Post_GroupId",
                table: "Post");

            migrationBuilder.DropIndex(
                name: "IX_Post_StudentAccountId",
                table: "Post");

            migrationBuilder.DropIndex(
                name: "IX_NoteBoards_StudentAccountId",
                table: "NoteBoards");

            migrationBuilder.DropIndex(
                name: "IX_Groups_StudentAccountId",
                table: "Groups");

            migrationBuilder.DropIndex(
                name: "IX_Fees_StudentAccountId",
                table: "Fees");

            migrationBuilder.DropIndex(
                name: "IX_Attendances_StudentAccountId",
                table: "Attendances");

            migrationBuilder.DropIndex(
                name: "IX_Activities_StudentAccountId",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "StudentAccountId",
                table: "Zooms");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "Post");

            migrationBuilder.DropColumn(
                name: "StudentAccountId",
                table: "Post");

            migrationBuilder.DropColumn(
                name: "StudentAccountId",
                table: "NoteBoards");

            migrationBuilder.DropColumn(
                name: "StudentAccountId",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "StudentAccountId",
                table: "Fees");

            migrationBuilder.DropColumn(
                name: "StudentAccountId",
                table: "Attendances");

            migrationBuilder.DropColumn(
                name: "StudentAccountId",
                table: "Activities");
        }
    }
}
