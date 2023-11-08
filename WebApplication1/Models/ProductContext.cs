using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace WebApplication1.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options)
            : base(options)
        {
         
        }

        public DbSet<Product> Products { get; set; } 

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Invoice> Invoices { get; set; }

        public DbSet<Detail> Details { get; set; }


    }
}
