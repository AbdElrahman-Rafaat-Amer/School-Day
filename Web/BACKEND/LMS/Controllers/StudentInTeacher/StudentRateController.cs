using LMS.Models.AccountModel;
using LMS.Models.ClassModel;

using LMS.Models.SectionModel;
using LMS.Models.StudentModel;
using LMS.Models.YearModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Controllers.StudentInTeacher
{
    [Route("[controller]")]
    [ApiController]
    public class StudentRateController : ControllerBase
    {
        private readonly IYearRepasitory<Year> _year;
        private readonly IClassRsepasitory<Class> _class;
        private readonly ISectionRepasitory<Section> _section;
        private readonly IAccountRepasitory _account;

        public StudentRateController(IYearRepasitory<Year> year,
            IClassRsepasitory<Class> @class,
            ISectionRepasitory<Section> section,
            IAccountRepasitory account)
        {
            _year = year;
            _class = @class;
            _section = section;
            _account = account;
        }
        [HttpGet("selectYear")]
        public ActionResult<List<Year>> Year()
        {
            return Ok(_year.Years());
        }
        [HttpGet("Selectclass")]
        public ActionResult<List<Class>> Class()
        {

            return Ok(_class.Classes());
        }
        [HttpGet("SelectSection")]
        public ActionResult<List<Section>> Section()
        {
            return Ok(_section.Sections());
        }
        [HttpGet("StudentNameSearch/{name}")]
        public ActionResult<List<Account>> StudentSearch(string studentName)
        {
            return Ok(_account.GetListByFilter(a => a.Fname == studentName || a.Mname == studentName || a.Lname == studentName));
        }
    }
}
