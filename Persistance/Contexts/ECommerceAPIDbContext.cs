using System;
using Application.Exceptions;
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
        public DbSet<ProductsCategory> Categories { get; set; } 
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            DbInitializer.SeedModel(modelBuilder);

            // Additional configurations for each entity
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(200);
                entity.Property(e => e.Description)
                    .HasMaxLength(500);
                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
                entity.Property(e => e.Stock)
                    .IsRequired();
                entity.Property(e => e.Price)
                    .IsRequired();
                entity.Property(e => e.Description)
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<ProductsCategory>(entity =>
            {
                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(100);
            });
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            // ChangeTracker: Track edilen verileri yakalayarak elde etmemizi sağlar. Interceptor olarak, Entity'ler üzerinde yapılan değişiklikleri ya da yeni eklenen verinin yakalanmasını sağlar.

            var datas = ChangeTracker
                .Entries<BaseEntity>();

            foreach (var data in datas)
            {
                _ = data.State switch
                {
                    EntityState.Added => data.Entity.CreatedDate = DateTime.UtcNow,
                    EntityState.Modified => data.Entity.UpdatedDate = DateTime.UtcNow,
                    EntityState.Unchanged => data.Entity.UpdatedDate, // No change for Unchanged state
                    EntityState.Deleted => data.Entity.UpdatedDate, // No change for Deleted state
                    EntityState.Detached => data.Entity.UpdatedDate // No change for Detached state
                };
            }
            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}

