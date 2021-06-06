using LMS.Models.TeacherModel;
using LMS.ViewModels.Teacher;
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
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherRepasitory<Teacher, TeacherProfileVM> _teacher;

        public TeacherController(ITeacherRepasitory<Teacher,TeacherProfileVM> teacher)
        {
            _teacher = teacher;
        }
        [HttpPost("addTeacher")]
        public ActionResult AddTeacher(Teacher teacher)
        {
            _teacher.CreateTeacher(teacher);
            return Ok("added succesfully");
        }
    }
}
