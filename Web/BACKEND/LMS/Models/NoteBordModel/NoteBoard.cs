using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.NoteBordModel
{
    public class NoteBoard
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public TaskModel.Task Task { get; set; }
        //public TeacherModel.Teacher Teacher { get; set; }
        //public StudentModel.Student Student { get; set; }
        public AccountModel.Account Account { get; set; }
        public SubjectModel.Subject Subject { get; set; }

    }
}
