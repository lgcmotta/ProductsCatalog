using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using ProductsCatalog.WebAPI.Infrastructure.EntityFramework.Context;

namespace ProductsCatalog.WebAPI.Infrastructure.EntityFramework.Migrations
{
    public class MigrateDbContext
    {
        private readonly IServiceProvider _serviceProvider;

        public MigrateDbContext(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateContext()
        {
            using var serviceScope = _serviceProvider.GetService<IServiceScopeFactory>().CreateScope();
            var context = serviceScope.ServiceProvider.GetRequiredService<ProductsDbContext>();
            //await context.Database.MigrateAsync();
            await context.Database.EnsureCreatedAsync();
        }
    }
}