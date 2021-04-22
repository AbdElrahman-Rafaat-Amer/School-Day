using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.LibraryModel.BorrowModel
{
    public class Borrow
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; }
        public BookModel.Book Book { get; set; }
        public AccountModel.Account Account { get; set; }
    }
}
