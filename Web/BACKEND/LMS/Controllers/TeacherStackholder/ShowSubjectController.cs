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
        private readonly ISubjectRepasitory<Subject> _subject;

        public ShowSubjectController(ISubjectRepasitory<Subject> subject)
        {
            _subject = subject;
        }
        [HttpGet("ShowSubject")]
        public ActionResult<List<ShowSubjectVM>> Show()
        {
            return Ok();
        }
    }
}
