using Microsoft.EntityFrameworkCore;
using Pilak.Database.Entities;

namespace Pilak.Database
{
    public interface IPersonRepository
    {
        Task<List<Person>> Get();
        Task Add(Person person);
    }

    public class PersonRepository(ApplicationDbContext context) : IPersonRepository
    {
        public async Task<List<Person>> Get()
        {
            var persons = await context.Persons.ToListAsync();
            return persons;
        }

        public async Task Add(Person person)
        {
            await context.Persons.AddAsync(person);
            await context.SaveChangesAsync();
        }
    }
}
