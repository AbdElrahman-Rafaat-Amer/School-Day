using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.TeacherModel
{
    public class PerformTeacher
    {
        private List<Teacher> _TeacherList;
        public PerformTeacher()
        {

            //<message from:Abdelrahman> You should delete these after my update on models

            //_TeacherList = new List<Teacher>()
            //{
            //    new Teacher(){Id=1,Fname="Ahmed",AddmitionDate=DateTime.Now,Height=80},
            //    new Teacher(){Id=2,Fname="Mostafa",AddmitionDate=DateTime.Now,Height=50},
            //    new Teacher(){Id=3,Fname="Saleh",AddmitionDate=DateTime.Now,Height=70}
            //};
        }

        public IEnumerable<Teacher> GetAllTeatcher()
        {
            return _TeacherList;
        }
        public Teacher GetTeatcher(int Id)
        {
            return _TeacherList.FirstOrDefault(s => s.AccountId == Id);
        }
    }
}
