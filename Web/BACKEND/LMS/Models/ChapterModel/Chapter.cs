using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.ChapterModel
{
    public class Chapter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
        public string Path { get; set; }
        public DateTime DateTime { get; set; }
        public SubjectModel.Subject Subject { get; set; }
        public YearModel.Year Year { get; set; }
    }
}
