using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.GroupModel
{
  public  interface IGroupRepasitory<T>
    {
        void CreateGroup(T Group);
        void UpdateGroup(T Group);
        void DeleteGroup(int Id);
        Task<Group> Group(int Id);
        List<Group> Groups();
    }
}
