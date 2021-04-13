using LMS.Models.RefreshTokenModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.ParentModel
{
    public class Parent
    {
        [Key]
        public int AccountId { get; set; }
        public string Natinality { get; set; }
        public string PDF_1 { get; set; }
        public string PDF_2 { get; set; }
        public string RelationWithStudent { get; set; }
        public ICollection<FeesModel.Fees> Fees { get; set; }
        public ICollection<TaskModel.Task> Tasks { get; set; }
        public ICollection<SubjectModel.Subject> Subjects { get; set; }
        public ICollection<StudentModel.Student> Students { get; set; }
    }       
}
