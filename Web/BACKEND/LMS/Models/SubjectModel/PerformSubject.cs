using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.SubjectModel
{
    public class PerformSubject : ISubjectRepasitory<Subject>
    {
        private readonly AppDbContext context;

        public PerformSubject(AppDbContext context)
        {
            this.context = context;
        }

        public void CreateSubject(Subject subject)
        {
            context.Subjects.Add(subject);
            context.SaveChangesAsync();
        }

        public void DeleteSubject(int Id)
        {
            Subject subject = context.Subjects.FirstOrDefault(e=>e.Id == Id);
            if(subject != null)
            {
                context.Subjects.Remove(subject);
                context.SaveChangesAsync();
            }
        }

        public async Task<Subject> Subject(int Id)
        {
            Subject subject = await context.Subjects.FindAsync(Id);
            return subject;
        }

        public List<Subject> Subjects()
        {
            return context.Subjects.ToList();
        }

        public void UpdateSubject(Subject subject)
        {
            context.Subjects.Update(subject);
            context.SaveChanges();
        }
    }
}
