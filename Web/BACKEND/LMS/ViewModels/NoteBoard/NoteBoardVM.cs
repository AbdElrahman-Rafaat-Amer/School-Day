using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.ViewModels.NoteBoard
{
    public class ShowNoteBoardVM
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Photo { get; set; }
        public string Color { get; set; }
        public int Taskid { get; set; }
        public int Subjectid { get; set; }

    }
}
