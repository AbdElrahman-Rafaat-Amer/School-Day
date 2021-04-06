using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.BusModel
{
    public class Bus
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public int NumberPlate { get; set; }
        public string LicenceCard { get; set; }
        public ICollection<DriverModel.Driver> Drivers { get; set; }

    }
}
