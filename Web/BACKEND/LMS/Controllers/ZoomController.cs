using LMS.Models.ZoomModel;
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
    public class ZoomController : ControllerBase
    {
        private readonly IZoomRepasitory<Zoom> _zoom;

        public ZoomController(IZoomRepasitory<Zoom> zoom)
        {
            _zoom = zoom;
        }
        [HttpPost("AddLink")]
        public ActionResult AddLink(Zoom zoom)
        {
            if (zoom != null)
            {
                _zoom.Add(zoom);
                return Ok();
            }
            return NotFound();
        }
        [HttpGet("ListLink")]
        public ActionResult<List<Zoom>> ListLink()
        {
            var z=_zoom.Links();
            return Ok(z);
        }
    }
}
