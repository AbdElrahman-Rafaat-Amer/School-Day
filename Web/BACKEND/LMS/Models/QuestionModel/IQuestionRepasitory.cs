using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.QuestionModel
{
   public interface IQuestionRepasitory<T>
    {
        void CreateQuestion(T question);
        void UpdateQuestion(T question);
        void DeleteQuestion(int Id);
        Task<Question> Question(int Id);
        List<Question> Questions();
    }
}
