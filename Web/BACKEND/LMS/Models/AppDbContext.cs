using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }
        public DbSet<Activity.Activity> Activities { get; set; }
        public DbSet<AnswerModel.Answer> Answers { get; set; }
        public DbSet<AttendanceModel.Attendance> Attendances { get; set; }
        public DbSet<BusModel.Bus> Buses { get; set; }
        public DbSet<ClassModel.Class> Classes { get; set; }
        public DbSet<CommentModel.Comment> Comments { get; set; }
        public DbSet<DriverModel.Driver> Drivers { get; set; }
        public DbSet<FeesModel.Fees> Fees{ get; set; }
        public DbSet<FileModel.File> Files { get; set; }
        public DbSet<FolderModel.Folder> Folders { get; set; }
        public DbSet<GroupModel.Group> Groups { get; set; }
        public DbSet<LibraryModel.BookModel.Book> Books { get; set; }
        public DbSet<LibraryModel.BorrowModel.Borrow> Borrows { get; set; }
        public DbSet<LibraryModel.CategoryModel.Category> Categories { get; set; }
        public DbSet<MCQModel.Mcq> Mcqs { get; set; }
        public DbSet<NoteBordModel.NoteBoard> NoteBoards { get; set; }
        public DbSet<ParentModel.Parent> Parents { get; set; }
        public DbSet<PayRollModel.PayRoll> PayRolls { get; set; }
        public DbSet<PhotoModel.Photo> Photos { get; set; }
        public DbSet<QuestionModel.Question> Questions { get; set; }
        public DbSet<SectionModel.Section> Sections { get; set; }
        public DbSet<StudentModel.Student> Students { get; set; }
        public DbSet<SubjectModel.Subject> Subjects { get; set; }
        public DbSet<TaskModel.Task> Tasks { get; set; }
        public DbSet<TeacherModel.Teacher> Teachers { get; set; }
        public DbSet<TrueFalseModel.TrueFalse> TrueFalses { get; set; }
        public DbSet<YearModel.Year> Years { get; set; }
        public DbSet<ZoomModel.Zoom> Zooms { get; set; }
        public DbSet<AccountModel.Account> Accounts { get; set; }
        public DbSet<AdminModel.Admin> Admin { get; set; }
        public DbSet<ChapterModel.Chapter> Chapters { get; set; }
        public DbSet<PostModel.Post> Posts { get; set; }

    }
}
