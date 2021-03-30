using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.TrueFalseModel
{
    public class TrueFalse
    {
        public int Id { get; set; }
        public Boolean CorrectAnswer { get; set; }
        public AnswerModel.Answer Answer { get; set; }

    }
}
