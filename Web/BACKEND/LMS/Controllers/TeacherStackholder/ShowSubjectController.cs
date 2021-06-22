using LMS.Models;
using LMS.Models.SubjectModel;
using LMS.ViewModels.TeacherVms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Controllers.TeacherStackholder
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShowSubjectController : ControllerBase
    {
        private readonly IAppRepo<ShowSubjectVM> repo;

        public ShowSubjectController(IAppRepo<ShowSubjectVM> repo)
        {
            this.repo = repo;
        }
        [HttpGet("ShowSubject")]
        public ActionResult<List<ShowSubjectVM>> Show()
        {
            return Ok(repo.List());
        }
    }
}
