using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.Activity
{
  public  interface IActivityRepasitory<T>
    {
        void CreateActivity(T Activity);
        void UpdateActivity(T Activity);
        void DeleteActivity(int Id);
        Task<Activity> Activity(int Id);
        List<Activity> Activitys();
    }
}
