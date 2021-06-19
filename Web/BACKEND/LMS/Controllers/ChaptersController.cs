using LMS.Models.ChapterModel;
using Microsoft.AspNetCore.Mvc;

namespace LMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChaptersController : ControllerBase
    {
        private readonly IChapterRepo<Chapter> _chapter;

        public ChaptersController(IChapterRepo<Chapter> chapter)
        {
            _chapter = chapter;
        }
        [HttpPost("AddChapter")]
        public ActionResult AddChapter(Chapter chapter)
        {
            if (chapter == null)
            {
                return BadRequest("data is null");

            }
            _chapter.CreateChapter(chapter);
            return Ok("chapter added succsully");
        }
        [HttpPut("UpdateChapter")]
        public ActionResult UpdateChapter(Chapter chapter)
        {
            if (chapter == null)
            {
                return BadRequest("data is null");

            }
            _chapter.UpdateChapter(chapter);
            return Ok("update chapter succsfully");
        }
        [HttpDelete("DeleteChapter/{id}")]
        public ActionResult DeleteChapter(int id)
        {
            var x = _chapter.Chapter(id);
            if (x == null)
            {
                return BadRequest("data is null");
            }
            _chapter.DeleteChapter(id);
            return Ok("delete chapter succssuflly");
        }
    }

}
