using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.FolderModel
{
    public class PerformFolder : IFolderRepasitory<Folder>
    {

        private readonly AppDbContext context;

        public PerformFolder(AppDbContext context)
        {
            this.context = context;
        }
        public void CreateFolder(Folder Folder)
        {
            context.Folders.Add(Folder);
            context.SaveChanges();
        }

        public void DeleteFolder(int Id)
        {
            var t = context.Folders.Find(Id);
            if (t != null)
            {
                context.Folders.Remove(t);
                context.SaveChanges();
            }
        }

        public async Task<Folder> Folder(int Id)
        {
            var t = await context.Folders.FindAsync(Id);
            return t;
        }

        public List<Folder> Folders()
        {
            var t = context.Folders.ToList();
            return t;
        }

        public List<Folder> FoldersByFilter(Func<Folder, bool> lamda)
        {
            var f = context.Folders.Where(lamda).ToList();
            return f;
        }

        public void UpdateFolder(Folder Folder)
        {
            context.Folders.Update(Folder);
            context.SaveChanges();
        }
    }
}
