using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.LibraryModel.CategoryModel
{
   public interface ICategoeyRepasitory<T>
    {
        void CreateCategory(T category);
        void UpdateCategory(T category);
        void DeleteCategory(int Id);
        Task<Category> Category(int Id);
        List<Category> Categorys();
    }
}
