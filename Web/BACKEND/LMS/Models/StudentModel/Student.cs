using LMS.Models.RefreshTokenModel;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.StudentModel
{
    public enum BloodGroup
    {
        A,
        B,
        AB,
        O
    }
    public class Student
    {
        [Key]
        public int AccountId { get; set; }
        public DateTime AddmitionDate { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public string BloodGroup { get; set; }
        public string Nationality { get; set; }
        public string PDF_1 { get; set; }
        public string PDF_2 { get; set; }
        public string AddmitionNum { get; set; }
        public ICollection<FeesModel.Fees> Fees { get; set; }
        public ICollection<AttendanceModel.Attendance> Attendances { get; set; }
        public ICollection<GroupModel.Group> Groups { get; set; }
        public ICollection<Activity.Activity> Activities { get; set; }
        public ICollection<ZoomModel.Zoom> Zooms { get; set; }
        public ICollection<PostModel.Post> Posts { get; set; }
        public ICollection<NoteBordModel.NoteBoard> NoteBoards { get; set; }
        public YearModel.Year Year { get; set; }
        public ParentModel.Parent Parent { get; set; }
        public BusModel.Bus Bus { get; set; }
    }
}
