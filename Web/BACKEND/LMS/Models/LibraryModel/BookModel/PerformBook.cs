using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.LibraryModel.BookModel
{
    public class PerformBook: IBookRepasitory<Book>
    {
        private readonly AppDbContext context;

        public PerformBook(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<Book> Book(int Id)
        {

            var t = await context.Books.FindAsync(Id);
            return t;
        }

        public List<Book> Books()
        {
            var t = context.Books.ToList();
            return t;
        }

        public void CreateBook(Book Book)
        {
            context.Books.Add(Book);
            context.SaveChanges();
        }

        public void DeleteBook(int Id)
        {
            var t = context.Books.Find(Id);
            if (t != null)
            {
                context.Books.Remove(t);
                context.SaveChanges();
            }
        }

        public void UpdateBook(Book Book)
        {
            context.Books.Update(Book);
            context.SaveChanges();
        }
    }
}
