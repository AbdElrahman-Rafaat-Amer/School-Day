using LMS.Models.TeacherModel;
using LMS.ViewModels.TeacherVms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TeacherProfileController : ControllerBase
    {
        private readonly ITeacherRepasitory<Teacher, TeacherProfileVM> teacherRepasitory;

        public TeacherProfileController(ITeacherRepasitory<Teacher,TeacherProfileVM> teacherRepasitory)
        {
            this.teacherRepasitory = teacherRepasitory;
        }
        [HttpGet("profile")]
        public ActionResult<List<TeacherProfileVM>> Get()
        {
            return Ok(teacherRepasitory.Teachers());
        }



    }
}
