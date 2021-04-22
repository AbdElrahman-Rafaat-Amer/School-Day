using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.ZoomModel
{
    public class Zoom
    {
        public int Id { get; set; }
        public string Link { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public AccountModel.Account Account { get; set; }



    }
}
