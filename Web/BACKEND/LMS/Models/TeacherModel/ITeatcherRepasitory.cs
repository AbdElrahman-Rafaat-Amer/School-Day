using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.TeacherModel
{
  public interface ITeacherRepasitory<T>
    {
        
        void CreateTeacher(T Teacher);
        void UpdateTeacher(T Teacher);
        void DeleteTeacher(int Id);
        Task<Teacher> Teatcher(int Id);
        public List<Teacher> Teatchers();
    }
}
