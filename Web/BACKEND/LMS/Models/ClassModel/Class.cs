using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.ClassModel
{
    public class Class
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public YearModel.Year Year { get; set; }
        public ICollection<SectionModel.Section> Sections { get; set; }
    }
}
