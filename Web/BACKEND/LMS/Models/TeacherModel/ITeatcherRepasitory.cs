using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.TeacherModel
{
  public interface ITeacherRepasitory
    {
        Teacher GetTeatcher(int Id);
        public IEnumerable<Teacher> GetAllTeatcher();
    }
}
