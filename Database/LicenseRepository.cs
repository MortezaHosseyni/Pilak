using Microsoft.EntityFrameworkCore;
using Pilak.Database.Entities;

namespace Pilak.Database
{
    public class LicenseRepository(ApplicationDbContext context)
    {
        private readonly ApplicationDbContext _context = context;

        public async Task<List<License>> Get()
        {
            var licenses = await _context.Licenses.Include(l => l.Person).ToListAsync();
            return licenses;
        }

        public async Task Add(License license)
        {
            await _context.Licenses.AddAsync(license);
            await _context.SaveChangesAsync();
        }
    }
}
