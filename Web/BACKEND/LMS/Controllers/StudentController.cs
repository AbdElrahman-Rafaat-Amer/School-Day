using LMS.Models.StudentModel;
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
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepasitory<Student> student;

        public StudentController(IStudentRepasitory<Student> student)
        {
            this.student = student;
        }
        [HttpGet]
        public ActionResult<List<Student>> ListStudent()
        {
            var s = student.Students();
            return Ok(s);
        }
    }
}
