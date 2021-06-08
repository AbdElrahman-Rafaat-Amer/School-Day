using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.ZoomModel
{
   public interface IZoomRepasitory<T>
    {
        void Add(T table);
        List<T> Links();
        List<T> ListByFilter(Func<T, bool> lamad);
    }
}
