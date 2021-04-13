using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.PayRollModel
{
    public class PayRoll
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public double Salary { get; set; }
        public AccountModel.Account Account { get; set; }

    }
}
