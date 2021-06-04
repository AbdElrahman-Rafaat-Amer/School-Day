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
        private readonly IStudentRepasitory<Student> _student;

        public StudentController(IStudentRepasitory<Student> student)
        {
            _student = student;
        }
        [HttpGet("liststudent")]
        public ActionResult<List<Student>> ListStudent()
        {
            var s = _student.Students();
            return Ok(s);
        }
        [HttpPost("creatstudent")]
        public ActionResult CreateStudent(Student student)
        {
            if (student!=null)
            {
                _student.CreateStudent(student);
                return Ok("Created Successufly");
            }
            return BadRequest();
        }
        [HttpDelete("deleteStudent")]
        public ActionResult DeleteStudent(int id)
        {
            var s = _student.Student(id);
            if (s!=null)
            {
                _student.DeleteStudent(id);
                return Ok();
            }
            return BadRequest();
        }
    }
}
