using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.FeesModel
{
  public  interface IFeesRepasitory<T>
    {
        void CreateFees(T Fees);
        void UpdateFees(T Fees);
        void DeleteFees(int Id);
        Task<Fees> Fees(int Id);
        List<Fees> Feeses();
    }
}
