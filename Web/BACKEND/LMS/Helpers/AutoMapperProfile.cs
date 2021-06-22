using AutoMapper;
using LMS.ViewModels.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LMS.Models.StudentModel;
using LMS.Models.TeacherModel;
using LMS.Models.DriverModel;
using LMS.Models.ParentModel;
using LMS.Models.AccountModel;
using LMS.Models.AdminModel;
using LMS.ViewModels.TeacherVms;
using LMS.Models.SubjectModel;

namespace LMS.Helpers
{
    public class AutoMapperProfile : Profile
    {
        // mappings between model and entity objects
        public AutoMapperProfile()
        {
            

            CreateMap<Account, AccountResponse>();

            CreateMap<Account, AuthenticateResponse>();

            CreateMap<RegisterRequest, Account>();

            CreateMap<CreateRequest, Account>();

            CreateMap<UpdateRequest, Account>()
                .ForAllMembers(x => x.Condition(
                    (src, dest, prop) =>
                    {
                        // ignore null & empty string properties
                        if (prop == null) return false;
                        if (prop.GetType() == typeof(string) && string.IsNullOrEmpty((string)prop)) return false;

                        // ignore null role
                        if (x.DestinationMember.Name == "Role" && src.Role == null) return false;

                        return true;
                    }
                ));

            CreateMap<RegisterRequest, Student>();
            CreateMap<RegisterRequest, Admin>();
            CreateMap<RegisterRequest, Teacher>();
            CreateMap<RegisterRequest, Driver>();
            CreateMap<RegisterRequest, Parent>();
            CreateMap<List<Subject>, List<ShowSubjectVM>>();

        }
    }
}
