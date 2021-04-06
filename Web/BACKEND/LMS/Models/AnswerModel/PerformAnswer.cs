using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.AnswerModel
{
    public class PerformAnswer : IAnswerRepasitory<Answer>
    {

        private readonly AppDbContext context;

        public PerformAnswer(AppDbContext context)
        {
            this.context = context;
        }
        public async Task<Answer> Answer(int Id)
        {
            var t = await context.Answers.FindAsync(Id);
            return t;
        }

        public List<Answer> Answers()
        {
            var t = context.Answers.ToList();
            return t;
        }

        public void CreateAnswer(Answer Answer)
        {
            context.Answers.Add(Answer);
            context.SaveChanges();
        }

        public void DeleteAnswer(int Id)
        {
            var t = context.Answers.Find(Id);
            if (t != null)
            {
                context.Answers.Remove(t);
                context.SaveChanges();
            }
        }

        public void UpdateAnswer(Answer Answer)
        {
            context.Answers.Update(Answer);
            context.SaveChanges();
        }
    }
}
