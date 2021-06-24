using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.ViewModels.TeacherVms
{
    public class AddOnlineAssignmentVM
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string StartDate { get; set; }
        public string EndData { get; set; }
        public string Statuse { get; set; }
        public double Degree { get; set; }
        public double GivenDegree { get; set; }
        public int TimeForExam { get; set; }
        public string Note { get; set; }
        public int QestionNumber { get; set; }

        public int AccountId { get; set; }
        public int SubjectId { get; set; }
        public int YearId { get; set; }
    }
}
