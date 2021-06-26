using LMS.Services;
using LMS.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace LMS.Models.PostModel
{
    public class PerformPost : IPostRepasitory<FeedsVM>
    {
        private readonly AppDbContext _context;
        private readonly UploadFile _uploadFile;

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
            if (post.Photo!=null)
            {
                foreach (var item in post.Photo)
                {
                    UploadFile _uploadFile = new UploadFile();
                    PhotoModel.Photo photo = new PhotoModel.Photo();
                    photo._Photo = _uploadFile.UploadedFile(item,"Postphotos");
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

        public List<ShowFeedsVM> Posts()
        {
            var listPosts = _context.Posts.Include(a => a.Account).ToList();
            List<ShowFeedsVM> showFeeds = new List<ShowFeedsVM>();
            foreach (var item in listPosts)
            {
                string username = item.Account.Fname +" "+ item.Account.Mname +" "+ item.Account.Lname;
                showFeeds.Add(new ShowFeedsVM
                {
                    Text = item.Text,
                    Date = item.Date,
                    AccountId = item.Account.Id,
                    Id = item.Id,
                    Like = item.Like,
                    Image = item.Account.Photo,
                    Username = username,
                    Photos = _context.Photos.Where(a => a.Post == item).Select(a => a._Photo).ToList()
                });
            }
            return showFeeds;
        }

        public void UpdatePost(FeedsVM post)
        {
            throw new NotImplementedException();
        }
    }
}
