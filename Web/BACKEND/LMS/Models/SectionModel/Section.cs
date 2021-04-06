using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.SectionModel
{
    public class Section
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ClassModel.Class Class { get; set; }
    }
}
