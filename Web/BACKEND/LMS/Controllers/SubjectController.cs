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
        public ActionResult<Subject> Get(int id)
        {
            return Ok(service.Subject(id));
        }

        [HttpPost]
        [Authorize(Role.Admin)]
        public void Post([FromBody] Subject value)
        {
            service.CreateSubject(value);
        }

        [HttpPut("{id}")]
        [Authorize(Role.Admin)]
        public void Put(int id, Subject value)
        {
            if (id == value.Id)
            {
                service.UpdateSubject(value);
            }
        }

        [HttpDelete("{id}")]
        [Authorize(Role.Admin)]
        public void Delete(int id)
        {
            service.DeleteSubject(id);
        }
    }
}
