using LMS.Models;
using LMS.Models.ChapterModel;
using LMS.ViewModels.StudentVMs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Services
{
    public class ChapterDownlaodService : IAppRepo<ChaptersInSubjectVMs>
    {
        private readonly AppDbContext _context;

        public ChapterDownlaodService(AppDbContext context)
        {
            _context = context;
        }
        public void Create(ChaptersInSubjectVMs table)
        {
            throw new NotImplementedException();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<ChaptersInSubjectVMs> Find(int Id)
        {
            throw new NotImplementedException();
        }

        public List<ChaptersInSubjectVMs> ListSubject(int subjectId)
        {
            throw new NotImplementedException();

        }


        public List<ChaptersInSubjectVMs> ListByFilter(Func<ChaptersInSubjectVMs, bool> lamda)
        {
            throw new NotImplementedException();
        }

        public void Update(ChaptersInSubjectVMs table)
        {
            throw new NotImplementedException();
        }

        public List<ChaptersInSubjectVMs> List()
        {
            throw new NotImplementedException();
        }

        public List<ChaptersInSubjectVMs> ListFilterById(int id)
        {
            var x = _context.Subjects.Find(1);
            var a = _context.Chapters.Where(s => s.Subject == x).ToList();
            List<ChaptersInSubjectVMs> chapters = new List<ChaptersInSubjectVMs>();
            foreach (var item in a)
            {
                ChaptersInSubjectVMs vm = new ChaptersInSubjectVMs();
                vm.ChapterName = item.Name;
                vm.ChapterPhoto = item.Photo;
                vm.ChapterPath = item.Path;
                chapters.Add(vm);
            }
            return chapters;
        }
    }
}
