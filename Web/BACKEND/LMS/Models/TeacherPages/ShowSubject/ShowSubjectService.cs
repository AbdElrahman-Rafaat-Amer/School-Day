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
    public class ShowSubjectService : IAppRepo<Subject>
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public ShowSubjectService(AppDbContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public void Create(ShowSubjectVM table)
        {
            throw new NotImplementedException();
        }

        public void Create(Subject table)
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

        public List<Subject> List()
        {
            var subjects2 = _context.Subjects.ToList();
            var subjects = _context.Subjects.Include(y => y.Year).ToList();
            //var vM = _mapper.Map<List<Subject>, List<ShowSubjectVM>>(subjects);
            return subjects;
        }

        public List<ShowSubjectVM> ListByFilter(Func<ShowSubjectVM, bool> lamda)
        {
            throw new NotImplementedException();
        }

        public List<Subject> ListByFilter(Func<Subject, bool> lamda)
        {
            throw new NotImplementedException();
        }

        public void Update(ShowSubjectVM table)
        {
            throw new NotImplementedException();
        }

        public void Update(Subject table)
        {
            throw new NotImplementedException();
        }

        Task<Subject> IAppRepo<Subject>.Find(int Id)
        {
            throw new NotImplementedException();
        }

      
    }
}
