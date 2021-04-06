using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.ClassModel
{
    public class PerformClass : IClassRepasitory<Class>
    {
        private readonly AppDbContext context;

        public PerformClass(AppDbContext context)
        {
            this.context = context;
        }
        public async Task<Class> Class(int Id)
        {
            var t = await context.Classes.FindAsync(Id);
            return t;
        }

        public List<Class> Classes()
        {
            var t = context.Classes.ToList();
            return t;
        }

        public void CreateClass(Class Class)
        {
            context.Classes.Add(Class);
            context.SaveChanges();
        }

        public void DeleteClass(int Id)
        {
            var t = context.Classes.Find(Id);
            if (t != null)
            {
                context.Classes.Remove(t);
                context.SaveChanges();
            }
        }

        public void UpdateClass(Class Class)
        {
            context.Classes.Update(Class);
            context.SaveChanges();
        }
    }
}
