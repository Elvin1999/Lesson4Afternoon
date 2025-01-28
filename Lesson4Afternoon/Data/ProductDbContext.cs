using Lesson4Afternoon.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lesson4Afternoon.Data
{
    public class ProductDbContext:DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options)
            :base(options) 
        {
            
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
