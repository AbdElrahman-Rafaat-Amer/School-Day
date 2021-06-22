using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models
{
    public interface IAppRepo<T>
    {
        void Create(T table);
        void Update(T table);
        void Delete(int Id);
        Task<T> Find(int Id);
        List<T> List();
        List<T> ListByFilter(Func<T, bool> lamda);
        List<T> ListFilterById(int id);
    }
}
