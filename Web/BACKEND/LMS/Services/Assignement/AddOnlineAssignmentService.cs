using LMS.Controllers;
using LMS.Models;
using LMS.ViewModels.TeacherVms;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Services.Assignement
{
    public class AddOnlineAssignmentService :BaseController, IAppRepo<AddOnlineAssignmentVM>
    {
        private readonly AppDbContext context;

        public AddOnlineAssignmentService(AppDbContext context)
        {
            this.context = context;
        }
        public void Create(AddOnlineAssignmentVM online)
        {
            Models.TaskModel.Task task = new Models.TaskModel.Task();
            task.StartDate = Convert.ToDateTime(online.StartDate);
            task.EndData = Convert.ToDateTime(online.EndData);
            task.GivenDegree = online.GivenDegree;
            task.Degree = online.Degree;
            task.Account = context.Accounts.Find(Account.Id);
            task.Name = online.Name;
            task.Note = online.Note;
            task.TimeForExam = online.TimeForExam;
            task.Type = "Online";
            task.Year = context.Years.Find(online.YearId);
            task.Subject = context.Subjects.Find(online.SubjectId);
            context.Add(task);
            context.SaveChanges();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<AddOnlineAssignmentVM> Find(int Id)
        {
            throw new NotImplementedException();
        }

        public List<AddOnlineAssignmentVM> List()
        {
            throw new NotImplementedException();
        }

        public List<AddOnlineAssignmentVM> ListByFilter(Func<AddOnlineAssignmentVM, bool> lamda)
        {
            throw new NotImplementedException();
        }

        public List<AddOnlineAssignmentVM> ListFilterById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(AddOnlineAssignmentVM table)
        {
            throw new NotImplementedException();
        }
    }
}
