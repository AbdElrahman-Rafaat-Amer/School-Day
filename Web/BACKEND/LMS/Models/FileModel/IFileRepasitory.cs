using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.FileModel
{
    public interface IFileRepasitory<T>
    {
        void CreateFile(T File);
        void UpdateFile(T File);
        void DeleteFile(int Id);
        Task<File> File(int Id);
        List<File> Files();
    }
}
