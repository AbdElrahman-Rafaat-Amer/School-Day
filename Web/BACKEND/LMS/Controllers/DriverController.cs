using LMS.Models.DriverModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverController : ControllerBase
    {
        private readonly IDriverRepasitory<Driver> driver;

        public DriverController(IDriverRepasitory<Driver> driver)
        {
            this.driver = driver;
        }
        [HttpGet]
        public ActionResult<List<Driver>> Drivers()
        {
            var list = driver.Drivers();
            return Ok(list);
        }
        [HttpPost]
        public IActionResult AddDriver(Driver d)
        {
            driver.CreateDriver(d);
            return Ok();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Driver>> FindDriver(int id)
        {
            var find = await driver.Driver(id);
            return Ok(find);
        }
    }
}
