using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LMS.Migrations
{
    public partial class Securitymigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activities_Students_StudentId",
                table: "Activities");

            migrationBuilder.DropForeignKey(
                name: "FK_Attendances_Students_StudentId",
                table: "Attendances");

            migrationBuilder.DropForeignKey(
                name: "FK_Borrows_Teachers_TeacherId",
                table: "Borrows");

            migrationBuilder.DropForeignKey(
                name: "FK_BusDriver_Drivers_DriversId",
                table: "BusDriver");

            migrationBuilder.DropForeignKey(
                name: "FK_Fees_Parents_ParentId",
                table: "Fees");

            migrationBuilder.DropForeignKey(
                name: "FK_Fees_Students_StudentId",
                table: "Fees");

            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Students_StudentId",
                table: "Groups");

            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Teachers_TeacherId",
                table: "Groups");

            migrationBuilder.DropForeignKey(
                name: "FK_NoteBoards_Students_StudentId",
                table: "NoteBoards");

            migrationBuilder.DropForeignKey(
                name: "FK_NoteBoards_Teachers_TeacherId",
                table: "NoteBoards");

            migrationBuilder.DropForeignKey(
                name: "FK_PayRolls_Teachers_TeacherId",
                table: "PayRolls");

            migrationBuilder.DropForeignKey(
                name: "FK_Post_Students_StudentId",
                table: "Post");

            migrationBuilder.DropForeignKey(
                name: "FK_Post_Teachers_TeacherId",
                table: "Post");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Parents_ParentId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Parents_ParentId",
                table: "Subjects");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Parents_ParentId",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_TeacherYear_Teachers_TeachersId",
                table: "TeacherYear");

            migrationBuilder.DropForeignKey(
                name: "FK_Zooms_Students_StudentId",
                table: "Zooms");

            migrationBuilder.DropForeignKey(
                name: "FK_Zooms_Teachers_TeacherId",
                table: "Zooms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Teachers",
                table: "Teachers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Parents",
                table: "Parents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Drivers",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "CurrentAddress",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Fname",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Lname",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Mname",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "PermanentAddress",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Phone_1",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Phone_2",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Relegion",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "CurrentAddress",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Fname",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Lname",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Mname",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "PermanentAddress",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Phone_1",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Phone_2",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Relegion",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Parents");

            migrationBuilder.DropColumn(
                name: "CurrentAddress",
                table: "Parents");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Parents");

            migrationBuilder.DropColumn(
                name: "Fname",
                table: "Parents");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Parents");

            migrationBuilder.DropColumn(
                name: "Lname",
                table: "Parents");

            migrationBuilder.DropColumn(
                name: "Mname",
                table: "Parents");

            migrationBuilder.DropColumn(
                name: "PermanentAddress",
                table: "Parents");

            migrationBuilder.DropColumn(
                name: "Phone_1",
                table: "Parents");

            migrationBuilder.DropColumn(
                name: "Phone_2",
                table: "Parents");

            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Parents");

            migrationBuilder.DropColumn(
                name: "Relegion",
                table: "Parents");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "NationalID",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "Phone_1",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Drivers");

            migrationBuilder.RenameColumn(
                name: "TeacherId",
                table: "Zooms",
                newName: "TeacherAccountId");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Zooms",
                newName: "StudentAccountId");

            migrationBuilder.RenameIndex(
                name: "IX_Zooms_TeacherId",
                table: "Zooms",
                newName: "IX_Zooms_TeacherAccountId");

            migrationBuilder.RenameIndex(
                name: "IX_Zooms_StudentId",
                table: "Zooms",
                newName: "IX_Zooms_StudentAccountId");

            migrationBuilder.RenameColumn(
                name: "TeachersId",
                table: "TeacherYear",
                newName: "TeachersAccountId");

            migrationBuilder.RenameColumn(
                name: "NatinaliID",
                table: "Teachers",
                newName: "AccountId");

            migrationBuilder.RenameColumn(
                name: "ParentId",
                table: "Tasks",
                newName: "ParentAccountId");

            migrationBuilder.RenameIndex(
                name: "IX_Tasks_ParentId",
                table: "Tasks",
                newName: "IX_Tasks_ParentAccountId");

            migrationBuilder.RenameColumn(
                name: "ParentId",
                table: "Subjects",
                newName: "ParentAccountId");

            migrationBuilder.RenameIndex(
                name: "IX_Subjects_ParentId",
                table: "Subjects",
                newName: "IX_Subjects_ParentAccountId");

            migrationBuilder.RenameColumn(
                name: "ParentId",
                table: "Students",
                newName: "ParentAccountId");

            migrationBuilder.RenameColumn(
                name: "NatinaliID",
                table: "Students",
                newName: "AccountId");

            migrationBuilder.RenameIndex(
                name: "IX_Students_ParentId",
                table: "Students",
                newName: "IX_Students_ParentAccountId");

            migrationBuilder.RenameColumn(
                name: "TeacherId",
                table: "Post",
                newName: "TeacherAccountId");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Post",
                newName: "StudentAccountId");

            migrationBuilder.RenameIndex(
                name: "IX_Post_TeacherId",
                table: "Post",
                newName: "IX_Post_TeacherAccountId");

            migrationBuilder.RenameIndex(
                name: "IX_Post_StudentId",
                table: "Post",
                newName: "IX_Post_StudentAccountId");

            migrationBuilder.RenameColumn(
                name: "TeacherId",
                table: "PayRolls",
                newName: "TeacherAccountId");

            migrationBuilder.RenameIndex(
                name: "IX_PayRolls_TeacherId",
                table: "PayRolls",
                newName: "IX_PayRolls_TeacherAccountId");

            migrationBuilder.RenameColumn(
                name: "NatinaliID",
                table: "Parents",
                newName: "AccountId");

            migrationBuilder.RenameColumn(
                name: "TeacherId",
                table: "NoteBoards",
                newName: "TeacherAccountId");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "NoteBoards",
                newName: "StudentAccountId");

            migrationBuilder.RenameIndex(
                name: "IX_NoteBoards_TeacherId",
                table: "NoteBoards",
                newName: "IX_NoteBoards_TeacherAccountId");

            migrationBuilder.RenameIndex(
                name: "IX_NoteBoards_StudentId",
                table: "NoteBoards",
                newName: "IX_NoteBoards_StudentAccountId");

            migrationBuilder.RenameColumn(
                name: "TeacherId",
                table: "Groups",
                newName: "TeacherAccountId");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Groups",
                newName: "StudentAccountId");

            migrationBuilder.RenameIndex(
                name: "IX_Groups_TeacherId",
                table: "Groups",
                newName: "IX_Groups_TeacherAccountId");

            migrationBuilder.RenameIndex(
                name: "IX_Groups_StudentId",
                table: "Groups",
                newName: "IX_Groups_StudentAccountId");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Fees",
                newName: "StudentAccountId");

            migrationBuilder.RenameColumn(
                name: "ParentId",
                table: "Fees",
                newName: "ParentAccountId");

            migrationBuilder.RenameIndex(
                name: "IX_Fees_StudentId",
                table: "Fees",
                newName: "IX_Fees_StudentAccountId");

            migrationBuilder.RenameIndex(
                name: "IX_Fees_ParentId",
                table: "Fees",
                newName: "IX_Fees_ParentAccountId");

            migrationBuilder.RenameColumn(
                name: "Phone_2",
                table: "Drivers",
                newName: "AccountId");

            migrationBuilder.RenameColumn(
                name: "_Comment",
                table: "Comments",
                newName: "CommentText");

            migrationBuilder.RenameColumn(
                name: "DriversId",
                table: "BusDriver",
                newName: "DriversAccountId");

            migrationBuilder.RenameIndex(
                name: "IX_BusDriver_DriversId",
                table: "BusDriver",
                newName: "IX_BusDriver_DriversAccountId");

            migrationBuilder.RenameColumn(
                name: "TeacherId",
                table: "Borrows",
                newName: "TeacherAccountId");

            migrationBuilder.RenameIndex(
                name: "IX_Borrows_TeacherId",
                table: "Borrows",
                newName: "IX_Borrows_TeacherAccountId");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Attendances",
                newName: "StudentAccountId");

            migrationBuilder.RenameIndex(
                name: "IX_Attendances_StudentId",
                table: "Attendances",
                newName: "IX_Attendances_StudentAccountId");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Activities",
                newName: "StudentAccountId");

            migrationBuilder.RenameIndex(
                name: "IX_Activities_StudentId",
                table: "Activities",
                newName: "IX_Activities_StudentAccountId");

            migrationBuilder.AlterColumn<string>(
                name: "AddmitionNum",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "AddmitionNum",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "LicenseID",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Teachers",
                table: "Teachers",
                column: "AccountId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "AccountId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Parents",
                table: "Parents",
                column: "AccountId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Drivers",
                table: "Drivers",
                column: "AccountId");

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NationalID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone_1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone_2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Relegion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PermanentAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<int>(type: "int", nullable: false),
                    VerificationToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Verified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ResetToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResetTokenExpires = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PasswordReset = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    AddmitionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Height = table.Column<double>(type: "float", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    BloodGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Natinality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PDF_1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PDF_2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddmitionNum = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.AccountId);
                    table.ForeignKey(
                        name: "FK_Admin_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RefreshToken",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Expires = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedByIp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Revoked = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RevokedByIp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReplacedByToken = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshToken", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefreshToken_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RefreshToken_AccountId",
                table: "RefreshToken",
                column: "AccountId");

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
                name: "FK_Borrows_Teachers_TeacherAccountId",
                table: "Borrows",
                column: "TeacherAccountId",
                principalTable: "Teachers",
                principalColumn: "AccountId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BusDriver_Drivers_DriversAccountId",
                table: "BusDriver",
                column: "DriversAccountId",
                principalTable: "Drivers",
                principalColumn: "AccountId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Drivers_Accounts_AccountId",
                table: "Drivers",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Fees_Parents_ParentAccountId",
                table: "Fees",
                column: "ParentAccountId",
                principalTable: "Parents",
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
                name: "FK_Groups_Teachers_TeacherAccountId",
                table: "Groups",
                column: "TeacherAccountId",
                principalTable: "Teachers",
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
                name: "FK_Parents_Accounts_AccountId",
                table: "Parents",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_Post_Teachers_TeacherAccountId",
                table: "Post",
                column: "TeacherAccountId",
                principalTable: "Teachers",
                principalColumn: "AccountId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Accounts_AccountId",
                table: "Students",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Parents_ParentAccountId",
                table: "Students",
                column: "ParentAccountId",
                principalTable: "Parents",
                principalColumn: "AccountId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Parents_ParentAccountId",
                table: "Subjects",
                column: "ParentAccountId",
                principalTable: "Parents",
                principalColumn: "AccountId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Parents_ParentAccountId",
                table: "Tasks",
                column: "ParentAccountId",
                principalTable: "Parents",
                principalColumn: "AccountId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Accounts_AccountId",
                table: "Teachers",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherYear_Teachers_TeachersAccountId",
                table: "TeacherYear",
                column: "TeachersAccountId",
                principalTable: "Teachers",
                principalColumn: "AccountId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Zooms_Students_StudentAccountId",
                table: "Zooms",
                column: "StudentAccountId",
                principalTable: "Students",
                principalColumn: "AccountId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Zooms_Teachers_TeacherAccountId",
                table: "Zooms",
                column: "TeacherAccountId",
                principalTable: "Teachers",
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
                name: "FK_Borrows_Teachers_TeacherAccountId",
                table: "Borrows");

            migrationBuilder.DropForeignKey(
                name: "FK_BusDriver_Drivers_DriversAccountId",
                table: "BusDriver");

            migrationBuilder.DropForeignKey(
                name: "FK_Drivers_Accounts_AccountId",
                table: "Drivers");

            migrationBuilder.DropForeignKey(
                name: "FK_Fees_Parents_ParentAccountId",
                table: "Fees");

            migrationBuilder.DropForeignKey(
                name: "FK_Fees_Students_StudentAccountId",
                table: "Fees");

            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Students_StudentAccountId",
                table: "Groups");

            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Teachers_TeacherAccountId",
                table: "Groups");

            migrationBuilder.DropForeignKey(
                name: "FK_NoteBoards_Students_StudentAccountId",
                table: "NoteBoards");

            migrationBuilder.DropForeignKey(
                name: "FK_NoteBoards_Teachers_TeacherAccountId",
                table: "NoteBoards");

            migrationBuilder.DropForeignKey(
                name: "FK_Parents_Accounts_AccountId",
                table: "Parents");

            migrationBuilder.DropForeignKey(
                name: "FK_PayRolls_Teachers_TeacherAccountId",
                table: "PayRolls");

            migrationBuilder.DropForeignKey(
                name: "FK_Post_Students_StudentAccountId",
                table: "Post");

            migrationBuilder.DropForeignKey(
                name: "FK_Post_Teachers_TeacherAccountId",
                table: "Post");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Accounts_AccountId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Parents_ParentAccountId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Parents_ParentAccountId",
                table: "Subjects");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Parents_ParentAccountId",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Accounts_AccountId",
                table: "Teachers");

            migrationBuilder.DropForeignKey(
                name: "FK_TeacherYear_Teachers_TeachersAccountId",
                table: "TeacherYear");

            migrationBuilder.DropForeignKey(
                name: "FK_Zooms_Students_StudentAccountId",
                table: "Zooms");

            migrationBuilder.DropForeignKey(
                name: "FK_Zooms_Teachers_TeacherAccountId",
                table: "Zooms");

            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "RefreshToken");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Teachers",
                table: "Teachers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Parents",
                table: "Parents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Drivers",
                table: "Drivers");

            migrationBuilder.RenameColumn(
                name: "TeacherAccountId",
                table: "Zooms",
                newName: "TeacherId");

            migrationBuilder.RenameColumn(
                name: "StudentAccountId",
                table: "Zooms",
                newName: "StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Zooms_TeacherAccountId",
                table: "Zooms",
                newName: "IX_Zooms_TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_Zooms_StudentAccountId",
                table: "Zooms",
                newName: "IX_Zooms_StudentId");

            migrationBuilder.RenameColumn(
                name: "TeachersAccountId",
                table: "TeacherYear",
                newName: "TeachersId");

            migrationBuilder.RenameColumn(
                name: "AccountId",
                table: "Teachers",
                newName: "NatinaliID");

            migrationBuilder.RenameColumn(
                name: "ParentAccountId",
                table: "Tasks",
                newName: "ParentId");

            migrationBuilder.RenameIndex(
                name: "IX_Tasks_ParentAccountId",
                table: "Tasks",
                newName: "IX_Tasks_ParentId");

            migrationBuilder.RenameColumn(
                name: "ParentAccountId",
                table: "Subjects",
                newName: "ParentId");

            migrationBuilder.RenameIndex(
                name: "IX_Subjects_ParentAccountId",
                table: "Subjects",
                newName: "IX_Subjects_ParentId");

            migrationBuilder.RenameColumn(
                name: "ParentAccountId",
                table: "Students",
                newName: "ParentId");

            migrationBuilder.RenameColumn(
                name: "AccountId",
                table: "Students",
                newName: "NatinaliID");

            migrationBuilder.RenameIndex(
                name: "IX_Students_ParentAccountId",
                table: "Students",
                newName: "IX_Students_ParentId");

            migrationBuilder.RenameColumn(
                name: "TeacherAccountId",
                table: "Post",
                newName: "TeacherId");

            migrationBuilder.RenameColumn(
                name: "StudentAccountId",
                table: "Post",
                newName: "StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Post_TeacherAccountId",
                table: "Post",
                newName: "IX_Post_TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_Post_StudentAccountId",
                table: "Post",
                newName: "IX_Post_StudentId");

            migrationBuilder.RenameColumn(
                name: "TeacherAccountId",
                table: "PayRolls",
                newName: "TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_PayRolls_TeacherAccountId",
                table: "PayRolls",
                newName: "IX_PayRolls_TeacherId");

            migrationBuilder.RenameColumn(
                name: "AccountId",
                table: "Parents",
                newName: "NatinaliID");

            migrationBuilder.RenameColumn(
                name: "TeacherAccountId",
                table: "NoteBoards",
                newName: "TeacherId");

            migrationBuilder.RenameColumn(
                name: "StudentAccountId",
                table: "NoteBoards",
                newName: "StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_NoteBoards_TeacherAccountId",
                table: "NoteBoards",
                newName: "IX_NoteBoards_TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_NoteBoards_StudentAccountId",
                table: "NoteBoards",
                newName: "IX_NoteBoards_StudentId");

            migrationBuilder.RenameColumn(
                name: "TeacherAccountId",
                table: "Groups",
                newName: "TeacherId");

            migrationBuilder.RenameColumn(
                name: "StudentAccountId",
                table: "Groups",
                newName: "StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Groups_TeacherAccountId",
                table: "Groups",
                newName: "IX_Groups_TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_Groups_StudentAccountId",
                table: "Groups",
                newName: "IX_Groups_StudentId");

            migrationBuilder.RenameColumn(
                name: "StudentAccountId",
                table: "Fees",
                newName: "StudentId");

            migrationBuilder.RenameColumn(
                name: "ParentAccountId",
                table: "Fees",
                newName: "ParentId");

            migrationBuilder.RenameIndex(
                name: "IX_Fees_StudentAccountId",
                table: "Fees",
                newName: "IX_Fees_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Fees_ParentAccountId",
                table: "Fees",
                newName: "IX_Fees_ParentId");

            migrationBuilder.RenameColumn(
                name: "AccountId",
                table: "Drivers",
                newName: "Phone_2");

            migrationBuilder.RenameColumn(
                name: "CommentText",
                table: "Comments",
                newName: "_Comment");

            migrationBuilder.RenameColumn(
                name: "DriversAccountId",
                table: "BusDriver",
                newName: "DriversId");

            migrationBuilder.RenameIndex(
                name: "IX_BusDriver_DriversAccountId",
                table: "BusDriver",
                newName: "IX_BusDriver_DriversId");

            migrationBuilder.RenameColumn(
                name: "TeacherAccountId",
                table: "Borrows",
                newName: "TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_Borrows_TeacherAccountId",
                table: "Borrows",
                newName: "IX_Borrows_TeacherId");

            migrationBuilder.RenameColumn(
                name: "StudentAccountId",
                table: "Attendances",
                newName: "StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Attendances_StudentAccountId",
                table: "Attendances",
                newName: "IX_Attendances_StudentId");

            migrationBuilder.RenameColumn(
                name: "StudentAccountId",
                table: "Activities",
                newName: "StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Activities_StudentAccountId",
                table: "Activities",
                newName: "IX_Activities_StudentId");

            migrationBuilder.AlterColumn<int>(
                name: "AddmitionNum",
                table: "Teachers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Teachers",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "CurrentAddress",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Fname",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Lname",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Mname",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PermanentAddress",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone_1",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone_2",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Relegion",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AddmitionNum",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "CurrentAddress",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Fname",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Lname",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Mname",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PermanentAddress",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone_1",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone_2",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Relegion",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Parents",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "CurrentAddress",
                table: "Parents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Parents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Fname",
                table: "Parents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Parents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Lname",
                table: "Parents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Mname",
                table: "Parents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PermanentAddress",
                table: "Parents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone_1",
                table: "Parents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone_2",
                table: "Parents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "Parents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Relegion",
                table: "Parents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LicenseID",
                table: "Drivers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Drivers",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DateOfBirth",
                table: "Drivers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NationalID",
                table: "Drivers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Phone_1",
                table: "Drivers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Teachers",
                table: "Teachers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Parents",
                table: "Parents",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Drivers",
                table: "Drivers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Activities_Students_StudentId",
                table: "Activities",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Attendances_Students_StudentId",
                table: "Attendances",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Borrows_Teachers_TeacherId",
                table: "Borrows",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BusDriver_Drivers_DriversId",
                table: "BusDriver",
                column: "DriversId",
                principalTable: "Drivers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Fees_Parents_ParentId",
                table: "Fees",
                column: "ParentId",
                principalTable: "Parents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Fees_Students_StudentId",
                table: "Fees",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Students_StudentId",
                table: "Groups",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Teachers_TeacherId",
                table: "Groups",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NoteBoards_Students_StudentId",
                table: "NoteBoards",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NoteBoards_Teachers_TeacherId",
                table: "NoteBoards",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PayRolls_Teachers_TeacherId",
                table: "PayRolls",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Post_Students_StudentId",
                table: "Post",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Post_Teachers_TeacherId",
                table: "Post",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Parents_ParentId",
                table: "Students",
                column: "ParentId",
                principalTable: "Parents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Parents_ParentId",
                table: "Subjects",
                column: "ParentId",
                principalTable: "Parents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Parents_ParentId",
                table: "Tasks",
                column: "ParentId",
                principalTable: "Parents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherYear_Teachers_TeachersId",
                table: "TeacherYear",
                column: "TeachersId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Zooms_Students_StudentId",
                table: "Zooms",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Zooms_Teachers_TeacherId",
                table: "Zooms",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
