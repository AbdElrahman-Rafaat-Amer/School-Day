using LMS.Models.YearModel;
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
    public class YearsController : ControllerBase
    {
        private readonly IYearRepasitory<Year> _year;

        public YearsController(IYearRepasitory<Year> year)
        {
            _year = year;
        }
        [HttpPost("addYear")]
        public ActionResult AddYear(Year year)
        {
            if (year!=null)
            {
                _year.CreateYear(year);
                return Ok("Successuly");

            }
            return NotFound();
        }
    }
}
