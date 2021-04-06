using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.BusModel
{
    public interface IBusRepasitory<T>
    {
        void CreateBus(T Bus);
        void UpdateBus(T Bus);
        void DeleteBus(int Id);
        Task<Bus> Bus(int Id);
        List<Bus> Buses();
    }
}
