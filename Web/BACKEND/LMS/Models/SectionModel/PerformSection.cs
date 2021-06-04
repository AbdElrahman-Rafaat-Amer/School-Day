using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.SectionModel
{
    public class PerformSection : ISectionRepasitory<Section>
    {
        private readonly AppDbContext _context;

        public PerformSection(AppDbContext context)
        {
            _context = context;
        }
        public async void CreateSection(Section section)
        {
            _context.Add(section);
            await _context.SaveChangesAsync();
        }


        public async void DeleteSection(int Id)
        {
            var s = await _context.Sections.FindAsync(Id);
            _context.Remove(s);
            await _context.SaveChangesAsync();
        }


        public async Task<Section> Section(int Id)
        {
            var s = await _context.Sections.FindAsync(Id);
            return s;
        }

        public async Task<List<Section>> Sections()
        {
            var s = await _context.Sections.ToListAsync();
            return s;
        }

        public async void UpdateSection(Section section)
        {
            _context.Update(section);
            await _context.SaveChangesAsync();
        }
    }
}
