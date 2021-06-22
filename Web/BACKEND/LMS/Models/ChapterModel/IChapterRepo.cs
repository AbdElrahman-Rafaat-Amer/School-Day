using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.ChapterModel
{
    public interface IChapterRepo<T>
    {
        void CreateChapter(T Class);
        void UpdateChapter(T Class);
        void DeleteChapter(int Id);
        Task<Chapter> Chapter(int Id);
        Task<List<Chapter>> Chapters();
    }
}
