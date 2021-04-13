using Microsoft.EntityFrameworkCore.Migrations;

namespace LMS.Migrations
{
    public partial class updateRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "FK_NoteBoards_Teachers_TeacherAccountId",
                table: "NoteBoards");

            migrationBuilder.DropForeignKey(
                name: "FK_PayRolls_Teachers_TeacherAccountId",
                table: "PayRolls");

            migrationBuilder.DropForeignKey(
                name: "FK_Post_Students_StudentAccountId",
                table: "Post");

            migrationBuilder.DropForeignKey(
                name: "FK_Zooms_Students_StudentAccountId",
                table: "Zooms");

            migrationBuilder.DropIndex(
                name: "IX_Groups_StudentAccountId",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "StudentAccountId",
                table: "Groups");

            migrationBuilder.RenameColumn(
                name: "StudentAccountId",
                table: "Zooms",
                newName: "AccountId");

            migrationBuilder.RenameIndex(
                name: "IX_Zooms_StudentAccountId",
                table: "Zooms",
                newName: "IX_Zooms_AccountId");

            migrationBuilder.RenameColumn(
                name: "StudentAccountId",
                table: "Post",
                newName: "AccountId");

            migrationBuilder.RenameIndex(
                name: "IX_Post_StudentAccountId",
                table: "Post",
                newName: "IX_Post_AccountId");

            migrationBuilder.RenameColumn(
                name: "TeacherAccountId",
                table: "PayRolls",
                newName: "AccountId");

            migrationBuilder.RenameIndex(
                name: "IX_PayRolls_TeacherAccountId",
                table: "PayRolls",
                newName: "IX_PayRolls_AccountId");

            migrationBuilder.RenameColumn(
                name: "TeacherAccountId",
                table: "NoteBoards",
                newName: "SubjectId");

            migrationBuilder.RenameColumn(
                name: "StudentAccountId",
                table: "NoteBoards",
                newName: "AccountId");

            migrationBuilder.RenameIndex(
                name: "IX_NoteBoards_TeacherAccountId",
                table: "NoteBoards",
                newName: "IX_NoteBoards_SubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_NoteBoards_StudentAccountId",
                table: "NoteBoards",
                newName: "IX_NoteBoards_AccountId");

            migrationBuilder.RenameColumn(
                name: "StudentAccountId",
                table: "Fees",
                newName: "AccountId");

            migrationBuilder.RenameIndex(
                name: "IX_Fees_StudentAccountId",
                table: "Fees",
                newName: "IX_Fees_AccountId");

            migrationBuilder.RenameColumn(
                name: "StudentAccountId",
                table: "Attendances",
                newName: "AccountId");

            migrationBuilder.RenameIndex(
                name: "IX_Attendances_StudentAccountId",
                table: "Attendances",
                newName: "IX_Attendances_AccountId");

            migrationBuilder.RenameColumn(
                name: "StudentAccountId",
                table: "Activities",
                newName: "AccountId");

            migrationBuilder.RenameIndex(
                name: "IX_Activities_StudentAccountId",
                table: "Activities",
                newName: "IX_Activities_AccountId");

            migrationBuilder.AddColumn<int>(
                name: "AccountId",
                table: "Tasks",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SubjectId",
                table: "Tasks",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AccountId",
                table: "Subjects",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BusId",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AnswerId",
                table: "Mcqs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AccountId",
                table: "Comments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AccountId",
                table: "Borrows",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_AccountId",
                table: "Tasks",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_SubjectId",
                table: "Tasks",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_AccountId",
                table: "Subjects",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_BusId",
                table: "Students",
                column: "BusId");

            migrationBuilder.CreateIndex(
                name: "IX_Mcqs_AnswerId",
                table: "Mcqs",
                column: "AnswerId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_AccountId",
                table: "Comments",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Borrows_AccountId",
                table: "Borrows",
                column: "AccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_Activities_Accounts_AccountId",
                table: "Activities",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Attendances_Accounts_AccountId",
                table: "Attendances",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Borrows_Accounts_AccountId",
                table: "Borrows",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Accounts_AccountId",
                table: "Comments",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Fees_Accounts_AccountId",
                table: "Fees",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Mcqs_Answers_AnswerId",
                table: "Mcqs",
                column: "AnswerId",
                principalTable: "Answers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NoteBoards_Accounts_AccountId",
                table: "NoteBoards",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NoteBoards_Subjects_SubjectId",
                table: "NoteBoards",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PayRolls_Accounts_AccountId",
                table: "PayRolls",
                column: "AccountId",
                principalTable: "Accounts",
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
                name: "FK_Students_Buses_BusId",
                table: "Students",
                column: "BusId",
                principalTable: "Buses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Accounts_AccountId",
                table: "Subjects",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Accounts_AccountId",
                table: "Tasks",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Subjects_SubjectId",
                table: "Tasks",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Zooms_Accounts_AccountId",
                table: "Zooms",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activities_Accounts_AccountId",
                table: "Activities");

            migrationBuilder.DropForeignKey(
                name: "FK_Attendances_Accounts_AccountId",
                table: "Attendances");

            migrationBuilder.DropForeignKey(
                name: "FK_Borrows_Accounts_AccountId",
                table: "Borrows");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Accounts_AccountId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Fees_Accounts_AccountId",
                table: "Fees");

            migrationBuilder.DropForeignKey(
                name: "FK_Mcqs_Answers_AnswerId",
                table: "Mcqs");

            migrationBuilder.DropForeignKey(
                name: "FK_NoteBoards_Accounts_AccountId",
                table: "NoteBoards");

            migrationBuilder.DropForeignKey(
                name: "FK_NoteBoards_Subjects_SubjectId",
                table: "NoteBoards");

            migrationBuilder.DropForeignKey(
                name: "FK_PayRolls_Accounts_AccountId",
                table: "PayRolls");

            migrationBuilder.DropForeignKey(
                name: "FK_Post_Accounts_AccountId",
                table: "Post");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Buses_BusId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Accounts_AccountId",
                table: "Subjects");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Accounts_AccountId",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Subjects_SubjectId",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Zooms_Accounts_AccountId",
                table: "Zooms");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_AccountId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_SubjectId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Subjects_AccountId",
                table: "Subjects");

            migrationBuilder.DropIndex(
                name: "IX_Students_BusId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Mcqs_AnswerId",
                table: "Mcqs");

            migrationBuilder.DropIndex(
                name: "IX_Comments_AccountId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Borrows_AccountId",
                table: "Borrows");

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "SubjectId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "BusId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "AnswerId",
                table: "Mcqs");

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "Borrows");

            migrationBuilder.RenameColumn(
                name: "AccountId",
                table: "Zooms",
                newName: "StudentAccountId");

            migrationBuilder.RenameIndex(
                name: "IX_Zooms_AccountId",
                table: "Zooms",
                newName: "IX_Zooms_StudentAccountId");

            migrationBuilder.RenameColumn(
                name: "AccountId",
                table: "Post",
                newName: "StudentAccountId");

            migrationBuilder.RenameIndex(
                name: "IX_Post_AccountId",
                table: "Post",
                newName: "IX_Post_StudentAccountId");

            migrationBuilder.RenameColumn(
                name: "AccountId",
                table: "PayRolls",
                newName: "TeacherAccountId");

            migrationBuilder.RenameIndex(
                name: "IX_PayRolls_AccountId",
                table: "PayRolls",
                newName: "IX_PayRolls_TeacherAccountId");

            migrationBuilder.RenameColumn(
                name: "SubjectId",
                table: "NoteBoards",
                newName: "TeacherAccountId");

            migrationBuilder.RenameColumn(
                name: "AccountId",
                table: "NoteBoards",
                newName: "StudentAccountId");

            migrationBuilder.RenameIndex(
                name: "IX_NoteBoards_SubjectId",
                table: "NoteBoards",
                newName: "IX_NoteBoards_TeacherAccountId");

            migrationBuilder.RenameIndex(
                name: "IX_NoteBoards_AccountId",
                table: "NoteBoards",
                newName: "IX_NoteBoards_StudentAccountId");

            migrationBuilder.RenameColumn(
                name: "AccountId",
                table: "Fees",
                newName: "StudentAccountId");

            migrationBuilder.RenameIndex(
                name: "IX_Fees_AccountId",
                table: "Fees",
                newName: "IX_Fees_StudentAccountId");

            migrationBuilder.RenameColumn(
                name: "AccountId",
                table: "Attendances",
                newName: "StudentAccountId");

            migrationBuilder.RenameIndex(
                name: "IX_Attendances_AccountId",
                table: "Attendances",
                newName: "IX_Attendances_StudentAccountId");

            migrationBuilder.RenameColumn(
                name: "AccountId",
                table: "Activities",
                newName: "StudentAccountId");

            migrationBuilder.RenameIndex(
                name: "IX_Activities_AccountId",
                table: "Activities",
                newName: "IX_Activities_StudentAccountId");

            migrationBuilder.AddColumn<int>(
                name: "StudentAccountId",
                table: "Groups",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Groups_StudentAccountId",
                table: "Groups",
                column: "StudentAccountId");

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
                name: "FK_NoteBoards_Teachers_TeacherAccountId",
                table: "NoteBoards",
                column: "TeacherAccountId",
                principalTable: "Teachers",
                principalColumn: "AccountId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PayRolls_Teachers_TeacherAccountId",
                table: "PayRolls",
                column: "TeacherAccountId",
                principalTable: "Teachers",
                principalColumn: "AccountId",
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
    }
}
