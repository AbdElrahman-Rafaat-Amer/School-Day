using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.LibraryModel.BorrowModel
{
    public class PerformBorrow: IBorrowRepasitory<Borrow>
    {
        private readonly AppDbContext context;

        public PerformBorrow(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<Borrow> Borrow(int Id)
        {
            var t = await context.Borrows.FindAsync(Id);
            return t;
        }

        public List<Borrow> Borrows()
        {
            var t = context.Borrows.ToList();
            return t;
        }

        public void CreateBorrow(Borrow Borrow)
        {
            context.Borrows.Add(Borrow);
            context.SaveChanges();
        }

        public void DeleteBorrow(int Id)
        {
            var t = context.Borrows.Find(Id);
            if (t != null)
            {
                context.Borrows.Remove(t);
                context.SaveChanges();
            }
        }

        public void UpdateBorrow(Borrow Borrow)
        {
            context.Borrows.Update(Borrow);
            context.SaveChanges();
        }
    }
}
