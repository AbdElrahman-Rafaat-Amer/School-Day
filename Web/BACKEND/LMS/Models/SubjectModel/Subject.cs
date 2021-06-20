using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LMS.Models.SubjectModel
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfUPload { get; set; }
        public string Photo { get; set; }
        public string Color { get; set; }
        public YearModel.Year Year { get; set; }
        [JsonIgnore]
        public AccountModel.Account Account { get; set; }

    }
}
