using LMS.Models;
using LMS.ViewModels.TeacherVms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Controllers.TeacherStackholder.Assignment
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShowAssignmentController : ControllerBase
    {
        private readonly IAppRepo<ShowAssignmentVms> _showAssignemt;
        private readonly IAppRepo<ListSubjectVM> listsubject;
        private readonly IAppRepo<AddPdfAssignmentVms> addpdf;
        private readonly IAppRepo<ListYearsVM> _listYear;

        public ShowAssignmentController(IAppRepo<ShowAssignmentVms> showAssignemt,
            IAppRepo<ListSubjectVM> listsubject,
            IAppRepo<AddPdfAssignmentVms> addpdf,
            IAppRepo<ListYearsVM> listYear)
        {
            _showAssignemt = showAssignemt;
            this.listsubject = listsubject;
            this.addpdf = addpdf;
            _listYear = listYear;
        }
        [HttpGet("ShowAssignment")]
        public ActionResult<List<ShowAssignmentVms>> ShowAssignment()
        {
            return Ok(_showAssignemt.List());
        }
        [HttpGet("Listsubject")]
        public ActionResult<List<ListSubjectVM>> ListSubject()
        {
            return Ok(listsubject.List());
        }
        [HttpGet("ListYear")]
        public ActionResult<List<ListYearsVM>> ListYear()
        {
          return Ok( _listYear.List());
        }
        [HttpPost("UploadPDFAssigment")]
        public ActionResult UploadPDFAssigment(AddPdfAssignmentVms addPdf)
        {
            if (addPdf!=null)
            {
                addpdf.Create(addPdf);
                return Ok(" add pdf succsfully");
            }
            return BadRequest("Null");

        }
    }
}
