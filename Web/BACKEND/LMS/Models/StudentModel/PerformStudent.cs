using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.StudentModel
{
    public class PerformStudent : IStudentRepasitory<Student>
    {
        private readonly AppDbContext context;

        public PerformStudent(AppDbContext context)
        {
            this.context = context;
        }
        public void CreateStudent(Student student)
        {
            context.Add(student);
            context.SaveChanges();
        }

        public void DeleteStudent(int Id)
        {
            var s = context.Students.Find(Id);
            context.Remove(s);
            context.SaveChanges();
        }

        public async Task<Student> Student(int Id)
        {
            return await context.Students.FindAsync(Id);
        }

        public List<Student> Students()
        {
            return context.Students.ToList();
        }

        public void UpdateStudent(Student student)
        {
            context.Update(student);
            context.SaveChanges();
        }
        public List<Student> StudentsByFilter(Func<Student, bool> lamda)
        {
            var s=context.Students.Where(lamda).ToList();
            return s;
        }
    }
}

