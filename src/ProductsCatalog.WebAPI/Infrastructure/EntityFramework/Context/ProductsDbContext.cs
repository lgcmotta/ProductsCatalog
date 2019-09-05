using Microsoft.EntityFrameworkCore;
using ProductsCatalog.WebAPI.Core.Domain;
using ProductsCatalog.WebAPI.Infrastructure.EntityFramework.EntityConfigurations;

namespace ProductsCatalog.WebAPI.Infrastructure.EntityFramework.Context
{
    public class ProductsDbContext : DbContext
    {

        private readonly DbContextOptions<ProductsDbContext> _options;

        public ProductsDbContext(DbContextOptions<ProductsDbContext> options) : base(options)
        {
            _options = options;
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductEntityTypeConfiguration());
        }
    }
}