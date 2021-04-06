using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.MCQModel
{
  public  interface IMcqRepasitory<T>
    {
        void CreateMcq(T mcq);
        void UpdateMcq(T mcq);
        void DeleteMcq(int Id);
        Task<Mcq> Mcq(int Id);
        List<Mcq> Mcqs();
    }
}
