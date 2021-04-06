using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.ClassModel
{
  public interface IClassRepasitory<T>
    {
        void CreateClass(T Class);
        void UpdateClass(T Class);
        void DeleteClass(int Id);
        Task<Class> Class(int Id);
        List<Class> Classes();
    }
}
