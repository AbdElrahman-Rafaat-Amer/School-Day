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
        private readonly IAppRepo<Subject> repo;

        public ShowSubjectController(IAppRepo<Subject> repo)
        {
            this.repo = repo;
        }
        [HttpGet("ShowSubject")]
        public ActionResult<List<Subject>> Show()
        {
            return Ok(repo.List());
        }
    }
}
