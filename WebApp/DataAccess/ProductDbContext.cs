using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.DataAccess
{
    public class ProductDbContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=B3-16;Database=ProniaProductsDB;Trusted_Connection=True;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }

    }
}
