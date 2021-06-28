
using LMS.Controllers;
using LMS.Models;
using LMS.Models.TaskModel;
using LMS.ViewModels.TeacherVms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Services.Assignement
{
    public class AddPDFAssignemntService :BaseController, IAppRepo<AddPdfAssignmentVms>
    {
        private readonly AppDbContext _context;

        public AddPDFAssignemntService(AppDbContext context)
        {
            _context = context;
        }
        public void Create(AddPdfAssignmentVms table)
        {
            if (table!=null)
            {
                UploadFile uploadFile = new UploadFile();
                Models.TaskModel.Task task = new Models.TaskModel.Task();
                task.Account = _context.Accounts.Find(Account.Id);
                task.StartDate = Convert.ToDateTime(table.StartDate);
                task.EndData = Convert.ToDateTime(table.EndDate);
                task.UploadFile = uploadFile.UploadedFile(table.AssignmentPath, table.AssignmentPath.FileName);
                task.Subject = _context.Subjects.Find(table.SubjectId);
                task.Year = _context.Years.Find(table.YearId);
                if (DateTime.Compare(DateTime.Now, task.StartDate) == 1)
                    task.Statuse = "Open";
                else
                    task.Statuse = "Pennding";
                _context.Tasks.Add(task);
                _context.SaveChanges();
            }

            throw new NotImplementedException();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<AddPdfAssignmentVms> Find(int Id)
        {
            throw new NotImplementedException();
        }

        public List<AddPdfAssignmentVms> List()
        {
            throw new NotImplementedException();
        }

        public List<AddPdfAssignmentVms> ListByFilter(Func<AddPdfAssignmentVms, bool> lamda)
        {
            throw new NotImplementedException();
        }

        public List<AddPdfAssignmentVms> ListFilterById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(AddPdfAssignmentVms table)
        {
            throw new NotImplementedException();
        }
    }
}
