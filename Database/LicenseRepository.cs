using Microsoft.EntityFrameworkCore;
using Pilak.Database.Entities;
using Pilak.Models;

namespace Pilak.Database
{
    public interface ILicenseRepository
    {
        Task<List<License>> Get();
        Task<License?> Get(PlateDetectionResult parameters);
        Task Add(License license);
    }

    public class LicenseRepository(ApplicationDbContext context) : ILicenseRepository
    {
        public async Task<List<License>> Get()
        {
            var licenses = await context.Licenses.Include(l => l.Person).ToListAsync();
            return licenses;
        }

        public async Task<License?> Get(PlateDetectionResult parameters)
        {
            var license = await context.Licenses.Include(l => l.Person).Where(l => l.FirstDigitSection == int.Parse(parameters.firstDigitSection) &&
                l.LetterSection == parameters.letterSection &&
                l.SecondDigitSection == int.Parse(parameters.secondDigitSection) &&
                l.CityCode == int.Parse(parameters.cityCode)).FirstOrDefaultAsync();
            return license;
        }

        public async Task Add(License license)
        {
            await context.Licenses.AddAsync(license);
            await context.SaveChangesAsync();
        }
    }
}
