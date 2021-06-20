using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.YearModel
{
    public class PerformYear : IYearRepasitory<Year>
    {
        private readonly AppDbContext _context;

        public PerformYear( AppDbContext context)
        {
            _context = context;
        }
        public  void CreateYear(Year year)
        {
            _context.Add(year);
            _context.SaveChanges();
        }

        public async Task<Year> Year(int id)
        {
           var y= await _context.Years.FindAsync(id);
           return (y);
        }

        public async Task<List<Year>> Years()
        {
            var y = await _context.Years.ToListAsync();
            return y;
        }

        public List<Year> YearsByFilter(Func<Year, bool> lamda)
        {
            var y = _context.Years.Where(lamda).ToList();
            return y;
        }
    }
}
