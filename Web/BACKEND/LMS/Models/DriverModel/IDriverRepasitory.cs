using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.DriverModel
{
    public  interface IDriverRepasitory<T>
    {
        void CreateDriver(T Driver);
        void UpdateDriver(T Driver);
        void DeleteDriver(int Id);
        Task<Driver> Driver(int Id);
        List<Driver> Drivers();
    }
}
