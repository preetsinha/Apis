using Microsoft.EntityFrameworkCore;

namespace BookLabraryCrudApi.Models
{
    public class BookLaibraryContext : DbContext
    {
        public BookLaibraryContext(DbContextOptions<BookLaibraryContext> options) : base(options)
        {

        }

        public DbSet<BookLaibrary> Books { get; set; }
    }
}
