using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.ParentModel
{
    public class PerformParent : IParentRepasitory<Parent>
    {
        private readonly AppDbContext context;

        public PerformParent(AppDbContext context)
        {
            this.context = context;
        }
        public void CreateParent(Parent Parent)
        {
            context.Parents.Add(Parent);
            context.SaveChanges();
        }

        public void DeleteParent(int Id)
        {
            var t = context.Parents.Find(Id);
            if (t != null)
            {
                context.Parents.Remove(t);
                context.SaveChanges();
            }
        }

        public async Task<Parent> Parent(int Id)
        {
            var t = await context.Parents.FindAsync(Id);
            return t;
        }

        public List<Parent> Parents()
        {
            var t = context.Parents.ToList();
            return t;
        }

        public void UpdateParent(Parent Parent)
        {
            context.Parents.Update(Parent);
            context.SaveChanges();
        }
    }
}
