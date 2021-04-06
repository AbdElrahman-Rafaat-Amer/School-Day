using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.GroupModel
{
    public class PerformGroup : IGroupRepasitory<Group>
    {
        private readonly AppDbContext context;

        public PerformGroup(AppDbContext context)
        {
            this.context = context;
        }
        public void CreateGroup(Group Group)
        {
            context.Groups.Add(Group);
            context.SaveChanges();
        }

        public void DeleteGroup(int Id)
        {
            var t = context.Groups.Find(Id);
            if (t != null)
            {
                context.Groups.Remove(t);
                context.SaveChanges();
            }
        }

        public async Task<Group> Group(int Id)
        {
            var t = await context.Groups.FindAsync(Id);
            return t;
        }

        public List<Group> Groups()
        {
            var t = context.Groups.ToList();
            return t;
        }

        public void UpdateGroup(Group Group)
        {
            context.Groups.Update(Group);
            context.SaveChanges();
        }
    }
}
