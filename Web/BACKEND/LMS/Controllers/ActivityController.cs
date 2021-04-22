using LMS.Models.Activity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityController : ControllerBase
    {
        private readonly IActivityRepasitory<Activity> activity;

        public ActivityController(IActivityRepasitory<Activity> activity)
        {
            this.activity = activity;
        }
        [HttpPost]
        public IActionResult AddActivity(Activity a)
        {
            activity.CreateActivity(a);
            return Ok();
        }
        [HttpGet]
        public ActionResult<List<Activity>> ListAcitvites()
        {
            var list = activity.Activitys();
            return Ok(list);
        }
        [HttpGet("{id}")]
        public ActionResult<Activity> ActivityDetails(int id)
        {
            var x = activity.Activity(id);
            return Ok(x);
        }
    }
}
