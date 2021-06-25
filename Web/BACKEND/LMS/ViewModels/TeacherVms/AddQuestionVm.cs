using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.ViewModels.TeacherVms
{
    public class AddQuestionVm
    {
        public int TaskId { get; set; }
        public int Id { get; set; }
        public int QuestionNumber { get; set; }
        public string Text { get; set; }
        public string Note { get; set; }
        public string Type { get; set; }
        public List<AnswerVM> Answers { get; set; }

    }
}
