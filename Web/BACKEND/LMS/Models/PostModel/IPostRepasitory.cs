using LMS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.PostModel
{
  public interface IPostRepasitory<T>
    {
        void CreatePost(T post);
        void UpdatePost(T post);
        void DeletePost(int Id);
        Task<Post> Post(int Id);
        List<ShowFeedsVM> Posts();
    }
}
