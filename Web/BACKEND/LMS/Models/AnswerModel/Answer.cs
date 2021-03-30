using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.AnswerModel
{
    public class Answer
    {

        public int Id { get; set; }
        public string Text { get; set; }
        public string Type { get; set; }
        public string UploadFile { get; set; }
        public QuestionModel.Question Question { get; set; }
        public ICollection<TrueFalseModel.TrueFalse> TrueFalses { get; set; }

    }
}
