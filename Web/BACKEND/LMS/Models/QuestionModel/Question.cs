using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.QuestionModel
{
    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Note { get; set; }
        public string Type { get; set; }
        public ICollection<AnswerModel.Answer> Answers { get; set; }
        public TaskModel.Task Task { get; set; }

    }
}
