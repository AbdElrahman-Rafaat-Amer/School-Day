using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.DriverModel
{
    public class Driver
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public int Phone_1 { get; set; }
        public int Phone_2 { get; set; }
        public string Photo { get; set; }
        public string Address { get; set; }
        public int NationalID { get; set; }
        public int LicenseID { get; set; }
        public ICollection<BusModel.Bus> Buses { get; set; }

    }
}
