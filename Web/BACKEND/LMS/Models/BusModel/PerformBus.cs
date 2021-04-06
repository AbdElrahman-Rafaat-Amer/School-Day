using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.BusModel
{
    public class PerformBus : IBusRepasitory<Bus>
    {

        private readonly AppDbContext context;

        public PerformBus(AppDbContext context)
        {
            this.context = context;
        }
        public async Task<Bus> Bus(int Id)
        {
            var t = await context.Buses.FindAsync(Id);
            return t;
        }

        public List<Bus> Buses()
        {
            var t = context.Buses.ToList();
            return t;
        }

        public void CreateBus(Bus Bus)
        {
            context.Buses.Add(Bus);
            context.SaveChanges();
        }

        public void DeleteBus(int Id)
        {
            var t = context.Buses.Find(Id);
            if (t != null)
            {
                context.Buses.Remove(t);
                context.SaveChanges();
            }
        }

        public void UpdateBus(Bus Bus)
        {
            context.Buses.Update(Bus);
            context.SaveChanges();
        }
    }
}
