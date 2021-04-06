using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.AttendanceModel
{
  public  interface IAttendanceRepasitory<T>
    {
        void CreateAttendance(T Attendance);
        void UpdateAttendance(T Attendance);
        void DeleteAttendance(int Id);
        Task<Attendance> Attendance(int Id);
        List<Attendance> Attendances();
    }
}
