using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LMS.Models.FeesModel
{
    public class Fees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public double Amount { get; set; }
        public string PayMethod { get; set; }
        public double Discount { get; set; }
        public DateTime Date { get; set; }
        public double Paid { get; set; }
        public double Fine { get; set; }
        [JsonIgnore]
        public AccountModel.Account Account { get; set; }



    }
}
