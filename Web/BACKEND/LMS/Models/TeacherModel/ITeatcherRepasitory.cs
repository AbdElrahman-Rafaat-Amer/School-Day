using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.TeacherModel
{
  public interface ITeacherRepasitory<T,TT>
    {
        
        void CreateTeacher(T Teacher);
        void UpdateTeacher(T Teacher);
        void DeleteTeacher(int Id);
        Task<T> Teatcher(int Id);
        public List<T> Teatchers();
        public List<TT> Teachers();

    }
}
