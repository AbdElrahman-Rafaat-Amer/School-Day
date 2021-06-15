using LMS.ViewModels.TeacherVms;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.TeacherPages.ShowSubject
{
    public class ShowSubjectService : IAppRepo<ShowSubjectVM>
    {
        private readonly AppDbContext _context;

        public ShowSubjectService(AppDbContext context)
        {
            _context = context;
        }
        public void Create(ShowSubjectVM table)
        {
            throw new NotImplementedException();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<ShowSubjectVM> Find(int Id)
        {
            throw new NotImplementedException();
        }

        public List<ShowSubjectVM> List()
        {
            var subjects2 = _context.Subjects.ToList();
            //var subjects = _context.Subjects.Include(y => y.Year).ForEachAsync();
            //ShowSubjectVM vM=new ShowSubjectVM
            //{
            //    SubjectName
            //}
            throw new NotImplementedException();
        }

        public List<ShowSubjectVM> ListByFilter(Func<ShowSubjectVM, bool> lamda)
        {
            throw new NotImplementedException();
        }

        public void Update(ShowSubjectVM table)
        {
            throw new NotImplementedException();
        }
    }
}
