using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.AttendanceModel
{
    public class PerformAttendance : IAttendanceRepasitory<Attendance>
    {
        private readonly AppDbContext context;

        public PerformAttendance(AppDbContext context)
        {
            this.context = context;
        }
        public async Task<Attendance> Attendance(int Id)
        {
            var t = await context.Attendances.FindAsync(Id);
            return t;
        }

        public List<Attendance> Attendances()
        {
            var t = context.Attendances.ToList();
            return t;
        }

        public void CreateAttendance(Attendance Attendance)
        {
            context.Attendances.Add(Attendance);
            context.SaveChanges();
        }

        public void DeleteAttendance(int Id)
        {
            var t = context.Attendances.Find(Id);
            if (t != null)
            {
                context.Attendances.Remove(t);
                context.SaveChanges();
            }
        }

        public void UpdateAttendance(Attendance Attendance)
        {
            context.Attendances.Update(Attendance);
            context.SaveChanges();
        }
    }
}
