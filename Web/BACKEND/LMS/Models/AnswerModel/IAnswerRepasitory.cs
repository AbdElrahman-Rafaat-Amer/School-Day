using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.AnswerModel
{
  public  interface IAnswerRepasitory<T>
    {
        void CreateAnswer(T Answer);
        void UpdateAnswer(T Answer);
        void DeleteAnswer(int Id);
        Task<Answer> Answer(int Id);
        List<Answer> Answers();
    }
}
