using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.QuestionModel
{
   public interface IQuestionRepasitory
    {
        Question GetQuestion(int Id);
        public IEnumerable<Question> GetAllQuestion();
    }
}
