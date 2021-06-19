using LMS.Models.RefreshTokenModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.TeacherModel
{
    public class Teacher
    {
        [Key]
        public int AccountId { get; set; }
        public DateTime AddmitionDate { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public string BloodGroup { get; set; }
        public string Natinality { get; set; }
        public string PDF_1 { get; set; }
        public string PDF_2 { get; set; }
        public string AddmitionNum { get; set; }
        public double Rate { get; set; }
        public ICollection<ZoomModel.Zoom> Zooms { get; set; }
        public ICollection<GroupModel.Group> Groups { get; set; }
        //public ICollection<NoteBordModel.NoteBoard> NoteBoards { get; set; }
        public ICollection<PostModel.Post> Posts { get; set; }
        public ICollection<LibraryModel.BorrowModel.Borrow> Borrows { get; set; }
        public ICollection<YearModel.Year> Years { get; set; }

    }
}
