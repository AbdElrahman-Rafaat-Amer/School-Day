using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.DriverModel
{
    public class PerformDriver : IDriverRepasitory<Driver>
    {
        private readonly AppDbContext context;

        public PerformDriver(AppDbContext context)
        {
            this.context = context;
        }


        public void CreateDriver(Driver Driver)
        {
            if (Driver!=null)
            {
                context.Drivers.Add(Driver);
                context.SaveChanges();
            }
            
        }

        public void DeleteDriver(int Id)
        {
            var t = context.Drivers.Find(Id);
            if (t != null)
            {
                context.Drivers.Remove(t);
                context.SaveChanges();
            }
        }

        public async Task<Driver> Driver(int Id)
        {
            var t = await context.Drivers.FindAsync(Id);
            return t;
        }

        public List<Driver> Drivers()
        {
            var t = context.Drivers.ToList();
            return t;
        }

        public void UpdateDriver(Driver Driver)
        {
            context.Drivers.Update(Driver);
            context.SaveChanges();
        }
    }
}
