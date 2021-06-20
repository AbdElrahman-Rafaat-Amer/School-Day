using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.ViewModels.TeacherVms
{
    public class AddChapterVM
    {
        public int YearId { get; set; }
        public int SubjectId { get; set; }
        public string ChapterName { get; set; }

        public string ChapterPath { get; set; }
        public string ChapterPhoto { get; set; }
        public string DateOfUpload { get; set; }

    }
}
