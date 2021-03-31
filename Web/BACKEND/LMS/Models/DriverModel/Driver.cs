using LMS.Models.RefreshTokenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LMS.Models.RoleModel;
using System.ComponentModel.DataAnnotations;

namespace LMS.Models.DriverModel
{
    public class Driver
    {
        [Key]
        public int AccountId { get; set; }
        public int DateOfBirth { get; set; }
        public string Photo { get; set; }
        public string Address { get; set; }
        public string LicenseID { get; set; }
        public ICollection<BusModel.Bus> Buses { get; set; }

    }
}
