using LMS.Models.AccountModel;
using LMS.Models.SubjectModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SubjectController : BaseController
    {
        private readonly ISubjectRepasitory<Subject> service;

        public SubjectController(ISubjectRepasitory<Subject> subject)
        {
            this.service = subject;
        }

        [HttpGet]
        public ActionResult<Subject> Get()
        {
            return Ok(service.Subjects());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Subject>> Get(int id)
        {
            var result =await service.Subject(id);
            return Ok(result);
        }

        [HttpPost("CreateSubject")]
        //[Authorize(Role.Admin ,Role.Teacher)]
        public ActionResult Post(Subject value)
        {
            if (value != null)
            {
                service.CreateSubject(value);
                return Ok("dfgjkdfg");
            }
            return BadRequest();
        }

        [HttpPut("{id}")]
        [Authorize(Role.Admin, Role.Teacher)]
        public ActionResult Put(int id, Subject value)
        {
            if (id == value.Id)
            {
                service.UpdateSubject(value);
                return Ok();
            }
            return BadRequest();
        }

        [HttpDelete("{id}")]
        [Authorize(Role.Admin, Role.Teacher)]
        public ActionResult Delete(int id)
        {
            service.DeleteSubject(id);
            return Ok();
        }
    }
}
