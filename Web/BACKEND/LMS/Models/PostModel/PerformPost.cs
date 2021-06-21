using LMS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace LMS.Models.PostModel
{
    public class PerformPost : IPostRepasitory<FeedsVM>
    {
        private readonly AppDbContext _context;

        public PerformPost(AppDbContext context)
        {
           _context = context;
        }
        public void CreatePost(FeedsVM post)
        {
            Post p = new Post();
            p.Date = DateTime.Now;
            p.Text = post.Text;
            p.Like = 0;
            p.Account = _context.Accounts.Find(post.AccountId);
            _context.Add(p);
            _context.SaveChanges();
            if (post.Photo.Count!=0)
            {
                foreach (var item in post.Photo)
                {
                    PhotoModel.Photo photo = new PhotoModel.Photo();
                    photo._Photo = item;
                    photo.Post = _context.Posts.Find(p.Id);
                    _context.Photos.Add(photo);
                    _context.SaveChanges();
                }
            }
        }

        public void DeletePost(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Post> Post(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Post> Posts()
        {
            throw new NotImplementedException();
        }

        public void UpdatePost(FeedsVM post)
        {
            throw new NotImplementedException();
        }
    }
}
