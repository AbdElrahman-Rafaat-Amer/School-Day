using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.Activity
{
    public class Activity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Link { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DateEnd { get; set; }
        public AccountModel.Account Account{ get; set; }
        

    }
}
