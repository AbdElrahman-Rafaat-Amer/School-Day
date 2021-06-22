using LMS.Models;
using LMS.ViewModels.StudentVMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Services
{
    public class SubjectDownloadService : IAppRepo<SubjectDownloadsVms>
    {
        private readonly AppDbContext _context;

        public SubjectDownloadService(AppDbContext context)
        {
            _context = context;
        }
        public void Create(SubjectDownloadsVms table)
        {
            throw new NotImplementedException();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<SubjectDownloadsVms> Find(int Id)
        {
            throw new NotImplementedException();
        }

        public List<SubjectDownloadsVms> List()
        {
            var s=_context.Subjects.ToList();
            List<SubjectDownloadsVms> vms = new List<SubjectDownloadsVms>();
            foreach (var item in s)
            {
                SubjectDownloadsVms vm = new SubjectDownloadsVms();
                vm.SujectId = item.Id;
                vm.SubjectName = item.Name;
                vm.PhotoPath = item.Photo;
                vms.Add(vm);
            }
            return vms;

        }

        public List<SubjectDownloadsVms> ListByFilter(Func<SubjectDownloadsVms, bool> lamda)
        {
            throw new NotImplementedException();
        }

        public List<SubjectDownloadsVms> ListFilterById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(SubjectDownloadsVms table)
        {
            throw new NotImplementedException();
        }
    }
}
