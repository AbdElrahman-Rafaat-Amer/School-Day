using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.ViewModels.TeacherVms
{
    public class AnswerVM
    {

        public string Text { get; set; }
        public string Type { get; set; }
        public IFormFile UploadFile { get; set; }

    }
}
