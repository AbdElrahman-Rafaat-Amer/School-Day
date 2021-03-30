using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.SubjectModel
{
    public class PerformSubject
    {
        private List<Subject> _SubjectList;
        public PerformSubject()
        {


            _SubjectList = new List<Subject>()
            {
                new Subject(){Id=1,Name="Ahmed",DateOfUPload=DateTime.Now},
                new Subject(){Id=2,Name="Mostafa",DateOfUPload=DateTime.Now},
                new Subject(){Id=3,Name="Saleh",DateOfUPload=DateTime.Now}
            };
        }

        public IEnumerable<Subject> GetAllSubjectList()
        {
            return _SubjectList;
        }
        public Subject GetSubject(int Id)
        {
            return _SubjectList.FirstOrDefault(s => s.Id == Id);
        }

        public Subject GetSubject(string Name)
        {
            return _SubjectList.FirstOrDefault(s => s.Name == Name);
        }
    }
}
