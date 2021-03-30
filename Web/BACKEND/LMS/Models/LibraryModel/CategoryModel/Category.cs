using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.LibraryModel.CategoryModel
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<BookModel.Book> Books { get; set; }

    }
}
