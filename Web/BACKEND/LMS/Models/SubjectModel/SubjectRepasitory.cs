using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.SubjectModel
{
   public interface ISubjectRepasitory
    {
        Subject GetSubject(int Id);
        Subject GetSubject(string Name);
        public IEnumerable<Subject> GetAllSubjects();
    }
}
