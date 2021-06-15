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
            if (teacher==null)
            {
                return BadRequest("data is null");
            }
            _teacher.CreateTeacher(teacher);
            return Ok("added succesfully");
        }
        [HttpPost("updateTeacher")]
        public ActionResult UpdateTeacher(Teacher teacher)
        {
            if (teacher==null)
            {
                return BadRequest("data is null");
            }
            _teacher.UpdateTeacher(teacher);
            return Ok("Teacher is Updated");
        }
        [HttpDelete("DeleteTeacher")]
        public ActionResult DeleteTeacher(int id)
        {
            var t = _teacher.Teatcher(id);
            if (t!=null)
            {
                _teacher.DeleteTeacher(id);
                return Ok("teacher is deleted ");
            }
            return BadRequest("not found to delete");
        }
    }
}
