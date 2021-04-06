using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.CommentModel
{
  public interface ICommentRepasirory<T>
    {
        void CreateComment(T Comment);
        void UpdateComment(T Comment);
        void DeleteComment(int Id);
        Task<Comment> Comment(int Id);
        List<Comment> Comments();
    }
}
