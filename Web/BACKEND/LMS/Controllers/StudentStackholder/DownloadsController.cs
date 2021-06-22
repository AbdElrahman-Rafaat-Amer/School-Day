using LMS.Models;
using LMS.ViewModels.StudentVMs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Controllers.StudentStackholder
{
    [Route("[controller]")]
    [ApiController]
    public class DownloadsController : ControllerBase
    {
        private readonly IAppRepo<SubjectDownloadsVms> _subject;
        private readonly IAppRepo<ChaptersInSubjectVMs> _chapters;

        public DownloadsController(IAppRepo<SubjectDownloadsVms> subject,IAppRepo<ChaptersInSubjectVMs> chapters)
        {
           _subject = subject;
            _chapters = chapters;
        }
        [HttpGet("SubjectList")]
        public ActionResult<List<SubjectDownloadsVms>> SubjectList()
        {
            return Ok(_subject.List());
        }
        [HttpGet("Chapters/{subjectid}")]
        public ActionResult<List<ChaptersInSubjectVMs>> Chapters(int subjectid)
        {
            return Ok(_chapters.ListFilterById(subjectid));
        }

    }
}
