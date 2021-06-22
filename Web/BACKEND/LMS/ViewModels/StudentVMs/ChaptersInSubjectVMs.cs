using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.ViewModels.StudentVMs
{
    public class ChaptersInSubjectVMs
    {
        public int SubjectId { get; set; }
        public string ChapterName { get; set; }
        public string ChapterPath { get; set; }
        public string ChapterPhoto { get; set; }
    }
}
