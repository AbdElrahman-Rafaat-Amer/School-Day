using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.FileModel
{
    public interface IfilesRepasitory
    {
        File GetFile(int Id);
        public IEnumerable<File> GetAllFiles();
    }
}
