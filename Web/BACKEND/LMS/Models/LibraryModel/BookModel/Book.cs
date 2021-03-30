using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.LibraryModel.BookModel
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ReaderNumber { get; set; }
        public string BookPhoto { get; set; }
        public string PDF { get; set; }
        public DateTime Date { get; set; }
        public int Quantity { get; set; }
        public CategoryModel.Category Category { get; set; }
        public ICollection<BorrowModel.Borrow> Borrows { get; set; }

    }
}
