using LMS.Models.NoteBordModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LMS.Models.AccountModel;
using LMS.ViewModels.NoteBoard;

namespace LMS.Controllers
{
    [Route("[controller]")]
    [ApiController]
    //[Authorize(Role.Student, Role.Teacher, Role.Admin)]

    public class NoteController : BaseController
    {
        private readonly INoteRepasitory<NoteBoard> note;

        public NoteController(INoteRepasitory<NoteBoard> note)
        {
            this.note = note;
        }
        [HttpGet("ListOfNotes")]
        public ActionResult<List<ShowNoteBoardVM>> ListNote()
        {
            return Ok(note.Notes(n => n.Account == Account));
        }

        [HttpPost("CreateNote")]
        public IActionResult CreateNote(NoteCreateRequest n)
        {
            if (n != null)
            {
                n.Account = Account;
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
        [HttpDelete("DeleteNote/{id}")]
        public IActionResult DeleteNote(int id)
        {
            try
            {
                note.DeleteNote(id, Account);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
            
        }

        [HttpGet("GetSubjects")]
        public IActionResult GetSubject()
        {
            return Ok(note.SubjectInNote());
        }

        [HttpGet("GetSubjectById/{id}")]
        public IActionResult GetSubject(int id)
        {
            return Ok(note.GetSubject(id));
        }
    }
}
