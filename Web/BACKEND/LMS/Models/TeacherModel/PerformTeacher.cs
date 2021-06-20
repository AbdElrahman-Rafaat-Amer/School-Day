using AutoMapper;
using LMS.ViewModels.TeacherVms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.TeacherModel
{
    public class PerformTeacher : ITeacherRepasitory<Teacher,TeacherProfileVM>
    {
        private readonly AppDbContext context;
        private readonly IMapper _mapper;

        public PerformTeacher(AppDbContext context,IMapper mapper)
        {
            this.context = context;
            _mapper = mapper;
        }

        
        public void CreateTeacher(Teacher Teacher)
        {
            context.Teachers.Add(Teacher);
            context.SaveChanges();
        }

       
        public void DeleteTeacher(int Id)
        {
            var t = context.Teachers.Find(Id);
            if (t!=null)
            {
                context.Teachers.Remove(t);
                context.SaveChanges();
            }


        }

        public async Task<Teacher> Teatcher(int Id)
        {
            var t = await context.Teachers.FindAsync(Id);
            return t;
        }

        public List<Teacher> Teatchers()
        {
            var t = context.Teachers.ToList();
            return t;
        }
        public List<TeacherProfileVM> Teachers()
        {
            var t = context.Teachers.ToList();
            List<TeacherProfileVM> vMs = _mapper.Map<List<Teacher>, List<TeacherProfileVM>>(t) ;
            return vMs;
        }
        public void UpdateTeacher(Teacher Teacher)
        {
            context.Teachers.Update(Teacher);
            context.SaveChanges();
        }
    }


}
