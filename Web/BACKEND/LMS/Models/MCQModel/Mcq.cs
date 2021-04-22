using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.MCQModel
{
    public class Mcq
    {
        public int Id { get; set; }
        public string AnswerA { get; set; }
        public string AnswerB { get; set; }
        public string AnswerC{ get; set; }
        public string AnswerD { get; set; }
        public string CorrectAnswer { get; set; }
        public AnswerModel.Answer Answer { get; set; }
    }
}
