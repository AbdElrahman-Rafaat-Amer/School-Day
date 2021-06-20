using LMS.Models;
using LMS.Models.ChapterModel;
using LMS.ViewModels.TeacherVms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Controllers.TeacherStackholder
{
    [Route("[controller]")]
    [ApiController]
    public class ChaptersController : ControllerBase
    {
        private readonly IChapterRepo<AddChapterVM> chapter;
        private readonly IAppRepo<ListYearsVM> year;
        private readonly IAppRepo<ListSubjectVM> subject;

        public ChaptersController(IChapterRepo<AddChapterVM> chapter,
            IAppRepo<ListYearsVM> Year,
            IAppRepo<ListSubjectVM> subject)
        {
            this.chapter = chapter;
            year = Year;
            this.subject = subject;
        }
        [HttpGet("ListYear")]
        public ActionResult<List<ListYearsVM>> ListYear()
        {
            return Ok(year.List());
        }
        [HttpGet("ListSubject")]
        public ActionResult<List<ListSubjectVM>> ListSubject()
        {
            return Ok(subject.List());
        }
        [HttpPost("UploadChapter")]
        public ActionResult UploadChapter(AddChapterVM chapterVM)
        {
            chapter.CreateChapter(chapterVM);
            return Ok("Created Succssuflly");
        }
    }
}
