using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.FileModel
{
    public class PerformFiles
    {

        private List<File> _FileList;
        public PerformFiles()
        {


            _FileList = new List<File>()
            {
                new File(){Id=1,Name="dddd",DateOfUPload=DateTime.Now,FileName="gggggggggggg",FilePath="kkkk" },
                new File(){Id=2,Name="qqqq",DateOfUPload=DateTime.Now,FileName="ssssssssssss",FilePath="aaaa" },
                new File(){Id=3,Name="tttt",DateOfUPload=DateTime.Now,FileName="vvvvvvvvvvvv",FilePath="xxxx" }
            };
        }

        public IEnumerable<File> GetAllFiless()
        {
            return _FileList;
        }
        public File GetFile(int Id)
        {
            return _FileList.FirstOrDefault(s => s.Id == Id);
        }
    }
}

