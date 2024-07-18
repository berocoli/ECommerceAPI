using System;
using Domain;
using Domain.Entities.BaseEntity;
using Microsoft.EntityFrameworkCore;

namespace Persistance.Contexts
{
    public class ECommerceAPIDbContext : DbContext
    {
        public ECommerceAPIDbContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            // ChangeTracker: Track edilen verileri yakalayarak elde etmemizi sağlar. Interceptor olarak, Entity'ler üzerinde yapılan değişiklikleri ya da yeni eklenen verinin yakalanmasını sağlar.

            var datas = ChangeTracker
                .Entries<BaseEntity>();

            foreach(var data in datas)
            {
                _  = data.State switch
                {
                    EntityState.Added => data.Entity.CreatedDate = DateTime.UtcNow,
                    EntityState.Modified => data.Entity.UpdatedDate = DateTime.UtcNow,
                    EntityState.Unchanged => data.Entity.UpdatedDate, // No change needed for Unchanged state, just handle it
                    EntityState.Deleted => data.Entity.UpdatedDate, // No change needed for Deleted state, just handle it
                    EntityState.Detached => data.Entity.UpdatedDate // No change needed for Detached state, just handle it
                } ;
            }
            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}

