using LMS.ViewModels.TeacherVms;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.ChapterModel
{
    public class ChapterService : IChapterRepo<AddChapterVM>
    {
        private readonly AppDbContext context;

        public ChapterService(AppDbContext context)
        {
            this.context = context;
        }
        public async Task<Chapter> Chapter(int Id)
        {
            var c = await context.Chapters.FindAsync(Id);
            return c;
        }

        public async Task<List<Chapter>> Chapters()
        {
            var c = await context.Chapters.ToListAsync();
            return c;
        }

        public void CreateChapter(AddChapterVM chapter)
        {
            var sub=context.Subjects.Find(chapter.SubjectId);
            var year = context.Years.Find(chapter.YearId);
            Chapter ch = new Chapter
            {
                Name = chapter.ChapterName,
                Path = chapter.ChapterPath,
                Photo = chapter.ChapterPhoto,
                DateTime = DateTime.Now,
                Subject = sub,
                Year=year
            };
            context.Add(ch);
            context.SaveChanges();
        }

        public async void DeleteChapter(int Id)
        {
            var c = await context.Chapters.FindAsync(Id);
            context.Chapters.Remove(c);
            context.SaveChanges();
        }

        public void UpdateChapter(AddChapterVM chapter)
        {
            //context.Chapters.Update(chapter);
            context.SaveChanges();
        }
    }
}
