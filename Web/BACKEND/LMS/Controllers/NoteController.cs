using LMS.Models.NoteBordModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LMS.Models.AccountModel;

namespace LMS.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Authorize(Role.Student, Role.Teacher, Role.Admin)]

    public class NoteController : BaseController
    {
        private readonly INoteRepasitory<NoteBoard> note;

        public NoteController(INoteRepasitory<NoteBoard> note)
        {
            this.note = note;
        }
        [HttpGet]
        public ActionResult<List<NoteBoard>> ListNote()
        {
            return Ok(note.NotesByFiltter(n=>n.Account==Account));
        }

        [HttpPost("CreateNote")]

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
