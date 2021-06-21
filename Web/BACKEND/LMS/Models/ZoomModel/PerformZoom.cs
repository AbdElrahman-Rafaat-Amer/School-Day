using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.ZoomModel
{
    public class PerformZoom : IZoomRepasitory<Zoom>
    {
        private readonly AppDbContext _context;

        public PerformZoom(AppDbContext context)
        {
            _context = context;
        }
        public void Add(Zoom zoom)
        {
            var account = _context.Accounts.Find(zoom.Account.Id);
            if (account!=null)
            {
                zoom.Account = account;
            }
            _context.Add(zoom);
            _context.SaveChanges();
        }

        public List<Zoom> Links()
        {
           var z= _context.Zooms.ToList();
            return z;
        }

        public List<Zoom> ListByFilter(Func<Zoom, bool> lamad)
        {
            var z = _context.Zooms.Where(lamad).ToList();
            return z;
        }
    }
}
