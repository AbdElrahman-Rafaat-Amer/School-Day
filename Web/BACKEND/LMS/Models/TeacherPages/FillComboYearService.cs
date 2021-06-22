using LMS.ViewModels.TeacherVms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.TeacherPages
{
    public class FillComboYearService:IAppRepo<ListYearsVM>
    {
        private readonly AppDbContext context;

        public FillComboYearService(AppDbContext context)
        {
            this.context = context;
        }

        public void Create(ListYearsVM table)
        {
            throw new NotImplementedException();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<ListYearsVM> Find(int Id)
        {
            throw new NotImplementedException();
        }

        public List<ListYearsVM> List()
        {
            var y=context.Years.ToList();
            List<ListYearsVM> listYearsVMs = new List<ListYearsVM>();
            foreach (var item in y)
            {
                ListYearsVM vM = new ListYearsVM
                {
                    YearId = item.Id,
                    YearName = item.Name
                };
                listYearsVMs.Add(vM);
            }
            return listYearsVMs;
        }

        public List<ListYearsVM> ListByFilter(Func<ListYearsVM, bool> lamda)
        {
            throw new NotImplementedException();
        }

        public List<ListYearsVM> ListFilterById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(ListYearsVM table)
        {
            throw new NotImplementedException();
        }
    }
}
