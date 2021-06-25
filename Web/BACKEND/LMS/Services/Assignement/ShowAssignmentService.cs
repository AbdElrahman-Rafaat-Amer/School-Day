using LMS.Controllers;
using LMS.Models;
using LMS.ViewModels;
using LMS.ViewModels.TeacherVms;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Services.Assignement
{
    public class ShowAssignmentService : BaseController, IAppRepo<ShowAssignmentVms>
    {
        private readonly AppDbContext context;

        public ShowAssignmentService(AppDbContext context)
        {
            this.context = context;
        }
        public void Create(ShowAssignmentVms table)
        {
            throw new NotImplementedException();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<ShowAssignmentVms> Find(int Id)
        {
            throw new NotImplementedException();
        }

        public List<ShowAssignmentVms> List()
        {
            var account = context.Accounts.Find(Account.Id);
            var t = context.Tasks.
                  Where(t => t.Type == TypeOfTask.Assignment.ToString() && t.Account == account)
                  .Include(s => s.Subject ).Include(y=>y.Year).ToList();
            List<ShowAssignmentVms> vms = new List<ShowAssignmentVms>();
            foreach (var item in t)
            {
                ShowAssignmentVms show = new ShowAssignmentVms();
                show.Color = item.Subject.Color;
                show.StartDate= item.StartDate.ToString("yyyy/MM/dd");
                show.EndDate = item.EndData.ToString("yyyy/MM/dd");
                show.Year = item.Year.Name;
                vms.Add(show);
            }
            return vms;

        }

        public List<ShowAssignmentVms> ListByFilter(Func<ShowAssignmentVms, bool> lamda)
        {
            throw new NotImplementedException();
        }

        public List<ShowAssignmentVms> ListFilterById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(ShowAssignmentVms table)
        {
            throw new NotImplementedException();
        }
    }
}
