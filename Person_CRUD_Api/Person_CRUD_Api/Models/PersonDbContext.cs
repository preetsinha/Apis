
using Microsoft.EntityFrameworkCore;

namespace Person_CRUD_Api.Models
{
    public class PersonDbContext : DbContext
    {
        public PersonDbContext(DbContextOptions<PersonDbContext> options) : base(options)
        {

        }
        public DbSet<Person> Persons { get; set; }
    }
  
}
