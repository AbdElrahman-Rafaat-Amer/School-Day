using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.StudentModel
{
    public class PerformStudent : IStudentRepasitory
    {
        private List<Student> _studentList;
        public PerformStudent()
        {
            BloodGroup Blood = BloodGroup.A;
            _studentList = new List<Student>()
            {
                //<message from:Abdelrahman> You should delete these after my update on models

                //new Student(){Id=1,Fname="Mostafa",Mname="Adel",Lname="Saleh",Email="Mostafa.saleh9009@gmail.com",Gender="Male",Phone_1="01094548676",
                //Phone_2="01283857400",NatinaliID=1,Nationality="Egypt", Relegion="Muslim",Weight=70,Height=186,PermanentAddress="Alex",CurrentAddress="Cairo",
                //AddmitionDate=DateTime.Now,AddmitionNum=1,BloodGroup=Blood.ToString()},


                // new Student(){Id=2,Fname="Nabil",Mname="Helmy",Lname="Mansour",Email="Helmy.Mansor7887@gmail.com",Gender="Male",Phone_1="01094548676",
                //Phone_2="01283857400",NatinaliID=1,Nationality="Egypt", Relegion="Muslim",Weight=70,Height=186,PermanentAddress="Alex",CurrentAddress="Cairo",
                //AddmitionDate=DateTime.Now,AddmitionNum=1,BloodGroup=Blood.ToString()},


                //  new Student(){Id=3,Fname="Ahmed",Mname="Nagy",Lname="Shehab",Email="Nagy.sayed2464@gmail.com",Gender="Male",Phone_1="01094548676",
                //Phone_2="01283857400",NatinaliID=1,Nationality="Egypt", Relegion="Muslim",Weight=70,Height=186,PermanentAddress="Alex",CurrentAddress="Cairo",
                //AddmitionDate=DateTime.Now,AddmitionNum=1,BloodGroup=Blood.ToString()}
            };
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _studentList;
        }
        public Student GetStudent(int Id)
        {
            return _studentList.FirstOrDefault(s => s.AccountId == Id);
        }
    }
}

