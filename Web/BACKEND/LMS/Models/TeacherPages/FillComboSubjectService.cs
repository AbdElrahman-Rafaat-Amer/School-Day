using LMS.ViewModels.TeacherVms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.TeacherPages
{
    public class FillComboSubjectService : IAppRepo<ListSubjectVM>
    {
        private readonly AppDbContext context;

        public FillComboSubjectService(AppDbContext context)
        {
            this.context = context;
        }
        public void Create(ListSubjectVM table)
        {
            throw new NotImplementedException();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<ListSubjectVM> Find(int Id)
        {
            throw new NotImplementedException();
        }

        public List<ListSubjectVM> List()
        {
            var y = context.Subjects.ToList();
            List<ListSubjectVM> listSubjectVMs = new List<ListSubjectVM>();
            foreach (var item in y)
            {
                ListSubjectVM vM = new ListSubjectVM
                {
                    SubjectId = item.Id,
                    SubjectName = item.Name
                };
                listSubjectVMs.Add(vM);
            }
            return listSubjectVMs;
        }

        public List<ListSubjectVM> ListByFilter(Func<ListSubjectVM, bool> lamda)
        {
            throw new NotImplementedException();
        }

        public List<ListSubjectVM> ListFilterById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(ListSubjectVM table)
        {
            throw new NotImplementedException();
        }
    }
}
