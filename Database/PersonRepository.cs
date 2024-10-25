using Microsoft.EntityFrameworkCore;
using Pilak.Database.Entities;

namespace Pilak.Database
{
    public class PersonRepository(ApplicationDbContext context)
    {
        private readonly ApplicationDbContext _context = context;

        public async Task<List<Person>> Get()
        {
            var persons = await _context.Persons.ToListAsync();
            return persons;
        }

        public async Task Add(Person person)
        {
            await _context.Persons.AddAsync(person);
            await _context.SaveChangesAsync();
        }
    }
}
