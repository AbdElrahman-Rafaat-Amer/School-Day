using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.Activity
{
    public class PerformActivity : IActivityRepasitory<Activity>
    {

        private readonly AppDbContext context;

        public PerformActivity(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<Activity> Activity(int Id)
        {
            var t = await context.Activities.FindAsync(Id);
            return t;
        }

        public List<Activity> Activitys()
        {
            var t = context.Activities.ToList();
            return t;
        }

        public void CreateActivity(Activity Activity)
        {
            context.Activities.Add(Activity);
            context.SaveChanges();
        }

        public void DeleteActivity(int Id)
        {
            var t = context.Activities.Find(Id);
            if (t!=null)
            {
                context.Activities.Remove(t);
                context.SaveChanges();
            }
        }

        public void UpdateActivity(Activity Activity)
        {
            context.Activities.Update(Activity);
            context.SaveChanges();
        }
    }
}
