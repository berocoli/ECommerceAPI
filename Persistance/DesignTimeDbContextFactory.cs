using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Persistance.Contexts;

namespace Persistance
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ECommerceAPIDbContext>
    {
        public ECommerceAPIDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ECommerceAPIDbContext>();
            optionsBuilder.UseNpgsql(Configuration.ConnectionString);
            return new ECommerceAPIDbContext(optionsBuilder.Options);
        }
    }
}
