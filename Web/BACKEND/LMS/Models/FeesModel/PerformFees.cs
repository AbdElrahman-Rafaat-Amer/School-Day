using LMS.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.FeesModel
{
    public class PerformFees : BaseController , IFeesRepasitory<Fees>
    {
        private readonly AppDbContext context;

        public PerformFees(AppDbContext context)
        {
            this.context = context;
        }

        public void CreateFees(Fees Fees)
        {
            context.Fees.Add(Fees);
            context.SaveChanges();
        }

        public void DeleteFees(int Id)
        {
            var t = context.Fees.Find(Id);
            if (t != null)
            {
                context.Fees.Remove(t);
                context.SaveChanges();
            }
        }

        
        public async Task<Fees> Fees(int Id)
        {
            var t = await context.Fees.FindAsync(Id);
            return t;
        }

        public List<Fees> Feeses()
        {
            var t = context.Fees.ToList();
            return t;
        }

        public void UpdateFees(Fees Fees)
        {
            context.Fees.Update(Fees);
            context.SaveChanges();
        }
    }
}
