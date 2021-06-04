using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.ClassModel
{
  public interface IClassRsepasitory<T>
    {
        void CreateClass(T Class);
        void UpdateClass(T Class);
        void DeleteClass(int Id);
        Task<Class> Class(int Id);
        Task<List<Class>> Classes();
    }
}
