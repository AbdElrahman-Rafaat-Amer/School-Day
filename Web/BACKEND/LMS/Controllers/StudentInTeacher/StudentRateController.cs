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

        public StudentRateController(IYearRepasitory<Year> year)
        {
            _year = year;
        }
    }
}
