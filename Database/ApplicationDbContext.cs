using Microsoft.EntityFrameworkCore;
using Pilak.Database.Entities;

namespace Pilak.Database
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<License> Licenses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var databasePath = Path.Combine(Directory.GetCurrentDirectory(), "Pilak.db");
            optionsBuilder.UseSqlite($"Data Source={databasePath};");

            optionsBuilder.EnableSensitiveDataLogging();
        }
    }
}
