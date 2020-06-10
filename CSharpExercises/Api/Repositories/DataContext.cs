using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Repositories
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> data) : base(data)
        {
        }

        public DbSet<Person> Persons { get; set; }
    }
}