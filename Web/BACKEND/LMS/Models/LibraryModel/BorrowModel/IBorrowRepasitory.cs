using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.LibraryModel.BorrowModel
{
  public interface IBorrowRepasitory<B>
    {
        void CreateBorrow(B Borrow);
        void UpdateBorrow(B Borrow);
        void DeleteBorrow(int Id);
        Task<Borrow> Borrow(int Id);
        List<Borrow> Borrows();
    }
}
