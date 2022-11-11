using DatabaseProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DatabaseProject.DatabaseContext
{
    public class ProductContext : DbContext
    {
        internal readonly object Product;

        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Product>().HasKey(e => e.EmpId);
            base.OnModelCreating(modelbuilder);
        }

    }
}
