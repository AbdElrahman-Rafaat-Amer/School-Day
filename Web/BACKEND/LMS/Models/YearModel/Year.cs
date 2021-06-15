using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.YearModel
{
    public class Year
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ClassModel.Class> Classes { get; set; }
        public ICollection<StudentModel.Student> Students { get; set; }
        public ICollection<TeacherModel.Teacher> Teachers { get; set; }
        public ICollection<SubjectModel.Subject> Subjects { get; set; }


    }
}
