using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.ViewModels.TeacherVms
{
    public class AddPdfAssignmentVms
    {
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int SubjectId { get; set; }
        public int YearId { get; set; }
        public string AssignmentName { get; set; }
        public IFormFile AssignmentPath { get; set; }
        public IFormFile AssignmentPhoto { get; set; }
    }
}
