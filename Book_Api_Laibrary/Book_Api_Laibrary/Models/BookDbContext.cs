using Microsoft.EntityFrameworkCore;

namespace Book_Api_Laibrary.Models
{
    public class BookDbContext : DbContext
    {

        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options)
        {

        }

        public DbSet<BookLaibrary> Books { get; set; }
    }
}
