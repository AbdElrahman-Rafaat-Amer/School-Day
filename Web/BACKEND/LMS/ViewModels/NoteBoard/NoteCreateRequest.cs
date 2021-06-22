using LMS.Models.AccountModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.ViewModels.NoteBoard
{
    public class NoteCreateRequest
    {
        public string Text { get; set; }
        public string Title { get; set; }
        public Account Account { get; set; }
        public string Taskid { get; set; }
        public string Subjectid { get; set; }
    }
}
