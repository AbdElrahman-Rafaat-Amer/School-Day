using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.FileModel
{
    public class File
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfUPload { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public FolderModel.Folder Folder { get; set; }
    }
}
