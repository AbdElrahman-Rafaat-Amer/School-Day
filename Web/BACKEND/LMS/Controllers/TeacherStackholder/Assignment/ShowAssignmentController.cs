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

        public ShowAssignmentController(IAppRepo<ShowAssignmentVms> showAssignemt,IAppRepo<ListSubjectVM> listsubject)
        {
            _showAssignemt = showAssignemt;
            this.listsubject = listsubject;
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
    }
}
