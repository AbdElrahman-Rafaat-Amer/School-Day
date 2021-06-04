using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.YearModel
{
    public interface IYearRepasitory<T>
    {
        Task<List<T>> Years();
        List<T> YearsByFilter(Func<T, bool> lamda);
        Task<T> Year(int id);
        void CreateYear(T year);

    }
}
