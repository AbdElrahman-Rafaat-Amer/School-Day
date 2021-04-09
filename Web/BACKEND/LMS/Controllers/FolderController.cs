using LMS.Models.FolderModel;
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
    public class FolderController : ControllerBase
    {
        private readonly IFolderRepasitory<Folder> folder;

        public FolderController(IFolderRepasitory<Folder> folder)
        {
            this.folder = folder;
        }
        [HttpPost]
        public IActionResult AddFolder(Folder f)
        {
            folder.CreateFolder(f);
            return Ok("Folder Created Successfully");
        }
    }
}
