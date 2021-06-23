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
        public string AssignmentPath { get; set; }
        public string AssignmentPhoto { get; set; }
    }
}
