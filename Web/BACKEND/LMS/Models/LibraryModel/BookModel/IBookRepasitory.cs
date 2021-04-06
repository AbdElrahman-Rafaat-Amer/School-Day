using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.LibraryModel.BookModel
{
  public interface IBookRepasitory<B>
    {
        void CreateBook(B Book);
        void UpdateBook(B Book);
        void DeleteBook(int Id);
        Task<Book> Book(int Id);
        List<Book> Books();
    }
}
