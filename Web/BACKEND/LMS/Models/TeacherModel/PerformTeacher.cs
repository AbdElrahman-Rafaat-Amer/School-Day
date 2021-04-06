using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.TeacherModel
{
    public class PerformTeacher : ITeacherRepasitory<Teacher>
    {
        private readonly AppDbContext context;

        public PerformTeacher(AppDbContext context)
        {
            this.context = context;
        }

        
        public void CreateTeacher(Teacher Teacher)
        {
            context.Teachers.Add(Teacher);
            context.SaveChanges();
        }

       
        public void DeleteTeacher(int Id)
        {
            var t = context.Teachers.Find(Id);
            if (t!=null)
            {
                context.Teachers.Remove(t);
                context.SaveChanges();
            }


        }

        public async Task<Teacher> Teatcher(int Id)
        {
            var t = await context.Teachers.FindAsync(Id);
            return t;
        }

        public List<Teacher> Teatchers()
        {
            var t = context.Teachers.ToList();
            return t;
        }

        public void UpdateTeacher(Teacher Teacher)
        {
            context.Teachers.Update(Teacher);
            context.SaveChanges();
        }
    }


}
