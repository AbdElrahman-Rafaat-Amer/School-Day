using LMS.Models.FolderModel;
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
    public class FolderController : ControllerBase
    {
        private readonly IFolderRepasitory<Folder> folder;

        public FolderController(IFolderRepasitory<Folder> folder)
        {
            this.folder = folder;
        }
        [HttpGet("ShowFolder")]
        public ActionResult<List<Folder>> ShowFolder()
        {
            var x = folder.Folders();
            return Ok(x);

        }
        [HttpPost("AddFolder")]
        public IActionResult AddFolder(Folder f)
        {
            folder.CreateFolder(f);
            return Ok("Folder Created Successfully");
        }
        [HttpPut("UpdateFolder")]
        public IActionResult UpdateFolder(Folder f)
        {
            if (f != null)
            {
                folder.UpdateFolder(f);
                return Ok();
            }
            return NotFound();
        }
        [HttpDelete("DeleteFolder/{id}")]
        public IActionResult DeleteFolder(int id)
        {
            if (id!=0)
            {
                folder.DeleteFolder(id);
                return Ok(); 
            }
            return NotFound();
        }
    }
}
