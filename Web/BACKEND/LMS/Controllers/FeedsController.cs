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
    public class FeedsController : ControllerBase
    {
        private readonly IPostRepasitory<FeedsVM> post;

        public FeedsController(IPostRepasitory<FeedsVM> post)
        {
            this.post = post;
        }

        [HttpPost("AddPost")]
        public ActionResult AddPost(FeedsVM feeds)
        {
            if (feeds!=null)
            {
                post.CreatePost(feeds);
                return Ok("Add Succssuly");

            }
            return BadRequest("is null");
        }

    }
}
