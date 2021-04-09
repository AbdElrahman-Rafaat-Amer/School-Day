using LMS.Models.BusModel;
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
    public class BusController : ControllerBase
    {
        private readonly IBusRepasitory<Bus> bus;

        public BusController(IBusRepasitory<Bus> bus)
        {
            this.bus = bus;
        }
        [HttpPost]
        public IActionResult AddBus(Bus b)
        {
            if (b!=null)
            {
                bus.CreateBus(b);
                return Ok("Bus Created successfully");
            }
            return NotFound();
        }
    }
}
