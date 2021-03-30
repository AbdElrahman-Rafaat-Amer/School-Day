using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.ParentModel
{
    public class Parent
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Mname { get; set; }
        public string Lname { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Phone_1 { get; set; }
        public string Phone_2 { get; set; }
        public string Relegion { get; set; }
        public string CurrentAddress { get; set; }
        public string PermanentAddress { get; set; }
        public string Natinality { get; set; }
        public string Photo { get; set; }
        public string PDF_1 { get; set; }
        public string PDF_2 { get; set; }
        public int NatinaliID { get; set; }
        public string RelationWithStudent { get; set; }
        public ICollection<FeesModel.Fees> Fees{ get; set; }
        public ICollection<TaskModel.Task> Tasks { get; set; }
        public ICollection<SubjectModel.Subject> Subjects { get; set; }
        public ICollection<StudentModel.Student> Students { get; set; }
    }       
}
