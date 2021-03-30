using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.StudentModel
{
  public interface IStudentRepasitory
    {
        Student GetStudent(int Id);
        public IEnumerable<Student> GetAllStudents();
    }
}
