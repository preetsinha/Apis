using Microsoft.EntityFrameworkCore;

namespace PersonsApi.Models
{
    public class PersonDbContext : DbContext
    {
        public PersonDbContext(DbContextOptions<PersonDbContext> options) : base(options)
        {

        }

        public DbSet<Person> Persons { get; set; }
    }
}
