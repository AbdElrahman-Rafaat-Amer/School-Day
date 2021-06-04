using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.SectionModel
{
  public  interface ISectionRepasitory<T>
    {
        void CreateSection(T section);
        void UpdateSection(T section);
        void DeleteSection(int Id);
        Task<Section> Section(int Id);
        Task<List<Section>> Sections();
    }
}
