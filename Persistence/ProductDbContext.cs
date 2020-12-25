using Microsoft.EntityFrameworkCore;
using Product.Web.Api.Models;

namespace Product.Web.Api.Persistence
{
    public class ProductDbContext:DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options)
        :base(options)
        {
        }

        public DbSet<Products> products { get; set; }

    }
}