using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.FolderModel
{
    public class Folder
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfUpload { get; set; }
        public ICollection<FileModel.File> Files { get; set; }
        public SubjectModel.Subject Subject { get; set; }

    }
}
