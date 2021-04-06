using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.FileModel
{
    public class PerformFile : IFileRepasitory<File>
    {

        private readonly AppDbContext context;

        public PerformFile(AppDbContext context)
        {
            this.context = context;
        }
        public void CreateFile(File File)
        {
            context.Files.Add(File);
            context.SaveChanges(); 
        }

        public void DeleteFile(int Id)
        {
            var t = context.Files.Find(Id);
            if (t != null)
            {
                context.Files.Remove(t);
                context.SaveChanges();
            }
        }

        public async Task<File> File(int Id)
        {
            var t = await context.Files.FindAsync(Id);
            return t;
        }

        public List<File> Files()
        {
            var t = context.Files.ToList();
            return t;
        }

        public void UpdateFile(File File)
        {
            context.Files.Update(File);
            context.SaveChanges();
        }
    }
}

