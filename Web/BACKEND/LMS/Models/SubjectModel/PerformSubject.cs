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
            if (subject.Account!=null)
            {
                var account = context.Accounts.Find(subject.Account.Id);
                subject.Account = account;
            }
            if (subject.Year!=null)
            {
                var year = context.Years.Find(subject.Year.Id);
                subject.Year = year;
            }
          
            context.Subjects.Add(subject);
            context.SaveChanges();
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
            var subject =await context.Subjects.FindAsync(Id);
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
