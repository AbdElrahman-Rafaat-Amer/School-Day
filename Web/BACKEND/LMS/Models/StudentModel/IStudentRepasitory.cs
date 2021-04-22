using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.StudentModel
{
  public interface IStudentRepasitory<T>
    {
        void CreateStudent(T student);
        void UpdateStudent(T student);
        void DeleteStudent(int Id);
        Task<Student> Student(int Id);
        List<Student> Students();
        List<Student> StudentsByFilter(Func<T, bool> lamda);
    }
}
