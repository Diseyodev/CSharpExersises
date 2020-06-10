using Api.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Repositories
{
    public class PersonRepository
    {
        private readonly DataContext _context;
        public PersonRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Person>> GetPersonListAsync()
        {
            return await _context.Persons.ToListAsync();
        }

        public async Task<int> AddPersonAsync(Person person)
        {
            _context.Persons.Add(person);
            await _context.SaveChangesAsync();

            return person.Id;
        }

        public async Task<Person> GetPersonAsync(int id)
        {
            return await _context.Persons.FindAsync(id);
        }


    }
}