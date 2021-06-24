using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.TaskModel
{
    public class Task
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndData { get; set; }
        public string Statuse { get; set; }
        public double Degree { get; set; }
        public double GivenDegree { get; set; }
        public int TimeForExam { get; set; }
        public int QuestionNumber { get; set; }
        public string Note { get; set; }
        public string UploadFile { get; set; }
        public AccountModel.Account Account { get; set; }
        public SubjectModel.Subject Subject { get; set; }
        public YearModel.Year Year { get; set; }
        public ICollection<QuestionModel.Question> Questions { get; set; }

    }
}
