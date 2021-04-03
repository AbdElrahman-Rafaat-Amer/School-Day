using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.AdminModel
{
    public class Admin
    {
        [Key]
        public int AccountId { get; set; }
        public DateTime AddmitionDate { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public string BloodGroup { get; set; }
        public string Natinality { get; set; }
        public string Photo { get; set; }
        public string PDF_1 { get; set; }
        public string PDF_2 { get; set; }
        public string AddmitionNum { get; set; }
    }
}
