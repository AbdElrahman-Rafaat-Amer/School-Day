using LMS.Models;
using LMS.ViewModels.TeacherVms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LMS.Models.QuestionModel;
using LMS.Models.AnswerModel;

namespace LMS.Services.Assignement
{
    public class AddpdfQuestionService : IAppRepo<AddQuestionVm>
    {
        private readonly AppDbContext _context;

        public AddpdfQuestionService(AppDbContext context)
        {
            _context = context;
        }
        public void Create(AddQuestionVm add)
        {
            
            Question q = new Question();
            q.Task = _context.Tasks.Find(add.TaskId);
            q.Note = add.Note;
            q.Text = add.Text;
            q.Type = add.Type;
            if (q.Type=="TrueorFalse")
            {

            }
            _context.Questions.Add(q);
            _context.SaveChanges();
            foreach (var item in add.Answers)
            {
                Answer answer = new Answer();
                answer.Text = item.Text;
                //answer.UploadFile = UploadFile.UploadedFile(item.UploadFile, item.Text);
                answer.Question = q;
                _context.Answers.Add(answer);
                _context.SaveChanges();
            }
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<AddQuestionVm> Find(int Id)
        {
            throw new NotImplementedException();
        }

        public List<AddQuestionVm> List()
        {
            throw new NotImplementedException();
        }

        public List<AddQuestionVm> ListByFilter(Func<AddQuestionVm, bool> lamda)
        {
            throw new NotImplementedException();
        }

        public List<AddQuestionVm> ListFilterById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(AddQuestionVm table)
        {
            throw new NotImplementedException();
        }
    }
}
