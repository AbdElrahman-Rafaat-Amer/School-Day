using LMS.Models.NoteBordModel;
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
    public class NoteController : ControllerBase
    {
        private readonly INoteRepasitory<NoteBoard> note;

        public NoteController(INoteRepasitory<NoteBoard> note)
        {
            this.note = note;
        }
        [HttpGet]
        public ActionResult<List<NoteBoard>> ListNote()
        {
            return Ok(note.Notes());
        }
        [HttpPost]
        public IActionResult CreateNote(NoteBoard n)
        {
            if (n != null)
            {
                note.CreateNote(n);
                return Ok();
            }
            return NotFound();
        }
        [HttpPut]
        public IActionResult UpdateNote(NoteBoard n)
        {
            if (n != null)
            {
                note.UpdateNote(n);
                return Ok();
            }
            return NotFound();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteNote(int id)
        {
            note.DeleteNote(id);
            return Ok(" Note Deleted Successfully");
        }
    }
}
