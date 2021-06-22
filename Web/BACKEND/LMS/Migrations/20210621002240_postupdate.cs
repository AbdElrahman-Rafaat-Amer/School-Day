using Microsoft.EntityFrameworkCore.Migrations;

namespace LMS.Migrations
{
    public partial class postupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Post_PostId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Post_PostId",
                table: "Photos");

            migrationBuilder.DropForeignKey(
                name: "FK_Post_Accounts_AccountId",
                table: "Post");

            migrationBuilder.DropForeignKey(
                name: "FK_Post_Groups_GroupId",
                table: "Post");

            migrationBuilder.DropForeignKey(
                name: "FK_Post_Students_StudentAccountId",
                table: "Post");

            migrationBuilder.DropForeignKey(
                name: "FK_Post_Teachers_TeacherAccountId",
                table: "Post");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Post",
                table: "Post");

            migrationBuilder.RenameTable(
                name: "Post",
                newName: "Posts");

            migrationBuilder.RenameIndex(
                name: "IX_Post_TeacherAccountId",
                table: "Posts",
                newName: "IX_Posts_TeacherAccountId");

            migrationBuilder.RenameIndex(
                name: "IX_Post_StudentAccountId",
                table: "Posts",
                newName: "IX_Posts_StudentAccountId");

            migrationBuilder.RenameIndex(
                name: "IX_Post_GroupId",
                table: "Posts",
                newName: "IX_Posts_GroupId");

            migrationBuilder.RenameIndex(
                name: "IX_Post_AccountId",
                table: "Posts",
                newName: "IX_Posts_AccountId");

            migrationBuilder.AlterColumn<int>(
                name: "Like",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Posts",
                table: "Posts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Posts_PostId",
                table: "Comments",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Posts_PostId",
                table: "Photos",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Accounts_AccountId",
                table: "Posts",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Groups_GroupId",
                table: "Posts",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Students_StudentAccountId",
                table: "Posts",
                column: "StudentAccountId",
                principalTable: "Students",
                principalColumn: "AccountId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Teachers_TeacherAccountId",
                table: "Posts",
                column: "TeacherAccountId",
                principalTable: "Teachers",
                principalColumn: "AccountId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Posts_PostId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Posts_PostId",
                table: "Photos");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Accounts_AccountId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Groups_GroupId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Students_StudentAccountId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Teachers_TeacherAccountId",
                table: "Posts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Posts",
                table: "Posts");

            migrationBuilder.RenameTable(
                name: "Posts",
                newName: "Post");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_TeacherAccountId",
                table: "Post",
                newName: "IX_Post_TeacherAccountId");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_StudentAccountId",
                table: "Post",
                newName: "IX_Post_StudentAccountId");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_GroupId",
                table: "Post",
                newName: "IX_Post_GroupId");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_AccountId",
                table: "Post",
                newName: "IX_Post_AccountId");

            migrationBuilder.AlterColumn<string>(
                name: "Like",
                table: "Post",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Post",
                table: "Post",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Post_PostId",
                table: "Comments",
                column: "PostId",
                principalTable: "Post",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Post_PostId",
                table: "Photos",
                column: "PostId",
                principalTable: "Post",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Post_Accounts_AccountId",
                table: "Post",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
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
                name: "FK_Post_Teachers_TeacherAccountId",
                table: "Post",
                column: "TeacherAccountId",
                principalTable: "Teachers",
                principalColumn: "AccountId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
