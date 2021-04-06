using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.TrueFalseModel
{
  public interface ITruFalseRepasitory<T>
    {
        void CreateTrueFalse(T trueFalse);
        void UpdateTrueFalse(T trueFalse);
        void DeleteTrueFalse(int Id);
        Task<TrueFalse> TrueFalse(int Id);
        List<TrueFalse> TrueFalses();
    }
}
