using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.ChapterModel
{
    public class ChapterService : IChapterRepo<Chapter>
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

        public void CreateChapter(Chapter chapter)
        {
            context.Add(chapter);
            context.SaveChanges();
        }

        public async void DeleteChapter(int Id)
        {
            var c = await context.Chapters.FindAsync(Id);
            context.Chapters.Remove(c);
            context.SaveChanges();
        }

        public void UpdateChapter(Chapter chapter)
        {
            context.Chapters.Update(chapter);
            context.SaveChanges();
        }
    }
}
