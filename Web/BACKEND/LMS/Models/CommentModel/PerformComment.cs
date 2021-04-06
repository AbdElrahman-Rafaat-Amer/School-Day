using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.CommentModel
{
    public class PerformComment : ICommentRepasirory<Comment>
    {
        private readonly AppDbContext context;

        public PerformComment(AppDbContext context)
        {
            this.context = context;
        }
        public async Task<Comment> Comment(int Id)
        {
            var t = await context.Comments.FindAsync(Id);
            return t;
        }

        public List<Comment> Comments()
        {
            var t = context.Comments.ToList();
            return t;
        }

        public void CreateComment(Comment Comment)
        {
            context.Comments.Add(Comment);
            context.SaveChanges();
        }

        public void DeleteComment(int Id)
        {
            var t = context.Comments.Find(Id);
            if (t != null)
            {
                context.Comments.Remove(t);
                context.SaveChanges();
            }
        }

        public void UpdateComment(Comment Comment)
        {
            context.Comments.Update(Comment);
            context.SaveChanges();
        }
    }
}
