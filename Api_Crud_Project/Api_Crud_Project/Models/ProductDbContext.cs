using Microsoft.EntityFrameworkCore;

namespace Api_Crud_Project.Models
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options): base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
