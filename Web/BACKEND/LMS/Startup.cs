using ELearningAPI.Middleware;
using LMS.Helpers;
using LMS.Models;
using LMS.Models.AccountModel;
using LMS.Models.ChapterModel;
using LMS.Models.ClassModel;
using LMS.Models.FeesModel;
using LMS.Models.FolderModel;
using LMS.Models.NoteBordModel;
using LMS.Models.PostModel;
using LMS.Models.SectionModel;
using LMS.Models.StudentModel;
using LMS.Models.SubjectModel;
using LMS.Models.TeacherModel;
using LMS.Models.TeacherPages;
using LMS.Models.TeacherPages.ShowSubject;
using LMS.Models.YearModel;
using LMS.Services;
using LMS.Services.Assignement;
using LMS.ViewModels;
using LMS.ViewModels.StudentVMs;
using LMS.ViewModels.TeacherVms;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Services;

namespace LMS
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            });
            services.AddControllers().AddJsonOptions(x => x.JsonSerializerOptions.IgnoreNullValues = true);
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            

            // configure strongly typed settings object
            services.Configure<AppSettings>(Configuration.GetSection("AppSettings"));
            services.AddCors();
            // configure DI for application services
            services.AddScoped<IAccountRepasitory, PerformAccount>();
            services.AddScoped<IEmailService, EmailService>();
            services.AddScoped<INoteRepasitory<NoteBoard>, PerformNoteBoard>();
            services.AddScoped<IStudentRepasitory<Student>, PerformStudent>();
            services.AddScoped<IFolderRepasitory<Folder>, PerformFolder>();
            services.AddScoped<IFeesRepasitory<Fees>,PerformFees>();
            services.AddScoped<ISubjectRepasitory<Subject>, PerformSubject>();
            services.AddScoped<IYearRepasitory<Year>, PerformYear>();
            services.AddScoped<IClassRsepasitory<Class>, PerformClass>();
            services.AddScoped<ISectionRepasitory<Section>, PerformSection>();
            services.AddScoped<ITeacherRepasitory<Teacher, TeacherProfileVM>, PerformTeacher>();
            services.AddScoped<IAppRepo<ShowSubjectVM>, ShowSubjectService>();
            services.AddScoped<IChapterRepo<AddChapterVM>, ChapterService>();
            services.AddScoped<IAppRepo<ListSubjectVM>, FillComboSubjectService>();
            services.AddScoped<IAppRepo<ListYearsVM>, FillComboYearService>();
            services.AddScoped<IPostRepasitory<FeedsVM>, PerformPost>();
            services.AddScoped<IAppRepo<SubjectDownloadsVms>, SubjectDownloadService>();
            services.AddScoped<IAppRepo<ChaptersInSubjectVMs>, ChapterDownlaodService>();
            services.AddScoped<IAppRepo<ShowAssignmentVms>, ShowAssignmentService>();
            services.AddScoped<IAppRepo<AddPdfAssignmentVms>, AddPDFAssignemntService>();
            services.AddScoped<IAppRepo<AddQuestionVm>, AddpdfQuestionService>();
            services.AddScoped<IAppRepo<AddOnlineAssignmentVM>, AddOnlineAssignmentService>();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "LMS", Version = "v1" });
            });
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
               
            }
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "LMS v1"));

            // global cors policy
            app.UseCors(x => x
                .SetIsOriginAllowed(origin => true)
                .AllowAnyMethod()
                .AllowAnyHeader()
                .AllowCredentials());

            //app.UseHttpsRedirection();

            app.UseRouting();
            // global error handler
            app.UseMiddleware<ErrorHandlerMiddleware>();

            // custom jwt auth middleware
            app.UseMiddleware<JwtMiddleware>();
            app.UseDefaultFiles();
            app.UseStaticFiles();
            
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
