using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.AttendanceModel
{
    public class Attendance
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public string QRCode { get; set; }
        public AccountModel.Account Account { get; set; }

    }
}
