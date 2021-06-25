using LMS.Models.PostModel;
using LMS.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FeedsController : BaseController
    {
        private readonly IPostRepasitory<FeedsVM> post;

        public FeedsController(IPostRepasitory<FeedsVM> post)
        {
            this.post = post;
        }

        [HttpPost("AddPost")]
        public ActionResult AddPost([FromForm]FeedsVM feeds)
        {
            if (feeds!=null)
            {
                feeds.AccountId = Account.Id;
                post.CreatePost(feeds);
                return Ok("Add Succssuly");

            }
            return BadRequest("is null");
        }

        [HttpGet("GetAllPosts")]
        public ActionResult<List<ShowFeedsVM>> GetPosts()
        {
            return Ok(post.Posts());
        }

    }
}
