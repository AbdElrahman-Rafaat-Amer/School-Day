using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.ClassModel
{
    public class PerformClass : IClassRsepasitory<Class>
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

        public async Task<List<Class>> Classes()
        {
            var t = await context.Classes.ToListAsync();
            return t;
        }

        public async void CreateClass(Class Class)
        {
            context.Classes.Add(Class);
            await context.SaveChangesAsync();
        }

        public async void DeleteClass(int Id)
        {
            var t = context.Classes.Find(Id);
            if (t != null)
            {
                context.Classes.Remove(t);
                await context.SaveChangesAsync();
            }
        }

        public async void UpdateClass(Class Class)
        {
            context.Classes.Update(Class);
            await context.SaveChangesAsync();
        }
    }
}
