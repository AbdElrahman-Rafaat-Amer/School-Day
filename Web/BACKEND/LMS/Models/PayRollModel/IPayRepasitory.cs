using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.PayRollModel
{
   public interface IPayRepasitory<T>
    {
        void CreatePayroll(T patroll);
        void UpdatePayroll(T patroll);
        void DeletePayroll(int Id);
        Task<PayRoll> Payroll(int Id);
        List<PayRoll> Payrolls();
    }
}
