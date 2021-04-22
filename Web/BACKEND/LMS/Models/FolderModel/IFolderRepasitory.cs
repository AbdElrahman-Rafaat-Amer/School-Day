using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.FolderModel
{
  public  interface IFolderRepasitory<T>
    {
        void CreateFolder(T Folder);
        void UpdateFolder(T Folder);
        void DeleteFolder(int Id);
        Task<Folder> Folder(int Id);
        List<Folder> Folders();
        List<Folder> FoldersByFilter(Func<T, bool> lamda);
    }
}
