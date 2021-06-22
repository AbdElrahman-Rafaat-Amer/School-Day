using AutoMapper;
using LMS.Models.SubjectModel;
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
        private readonly IMapper _mapper;

        public ShowSubjectService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
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
            var subjects2 = _context.Subjects.FirstOrDefault();
            var subjects = _context.Subjects.Include(y => y.Year).ToList();
            List<ShowSubjectVM> Vm = new List<ShowSubjectVM>();
            foreach (var s in subjects)
            {

                ShowSubjectVM ss = new ShowSubjectVM
                {
                    Name = s.Name,
                    Photo = s.Photo,
                    DateOfUPload = s.DateOfUPload.ToString("yyyy/MM/dd"),
                    Year = "",
                };
                if (s.Year != null)
                {
                    ss.Year = s.Year.Name;

                };
                Vm.Add(ss);
            }
            return Vm;
        }

        public List<ShowSubjectVM> ListByFilter(Func<ShowSubjectVM, bool> lamda)
        {
            throw new NotImplementedException();
        }

        public List<ShowSubjectVM> ListFilterById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(ShowSubjectVM table)
        {
            throw new NotImplementedException();
        }



        Task<ShowSubjectVM> IAppRepo<ShowSubjectVM>.Find(int Id)
        {
            throw new NotImplementedException();
        }


    }
}
