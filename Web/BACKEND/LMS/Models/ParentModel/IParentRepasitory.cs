using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.ParentModel
{
 public  interface IParentRepasitory<B>
    {
        void CreateParent(B Parent);
        void UpdateParent(B Parent);
        void DeleteParent(int Id);
        Task<Parent> Parent(int Id);
        List<Parent> Parents();
    }
}
