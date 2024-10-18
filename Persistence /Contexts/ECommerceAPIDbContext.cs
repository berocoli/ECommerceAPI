using System;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using Domain.Entities;
using Domain.Entities.BaseEntity;
using Infrastructure.Operations;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Contexts
{
    public class ECommerceAPIDbContext : DbContext
    {
        public ECommerceAPIDbContext(DbContextOptions options) : base(options)
        { }

        // DbSets for your entities
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductsCategory> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // User Entity Configuration
            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Name)
                    .HasMaxLength(100);

                entity.Property(e => e.Surname)
                    .HasMaxLength(100);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(256);

                // Configure one-to-one relationship with Cart
                entity.HasOne(u => u.Cart)
                    .WithOne(c => c.User)
                    .HasForeignKey<Cart>(c => c.UserId)
                    .OnDelete(DeleteBehavior.Cascade);

                // Configure one-to-many relationship with Orders
                entity.HasMany(u => u.Orders)
                    .WithOne(o => o.User)
                    .HasForeignKey(o => o.UserId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            // Product Entity Configuration
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

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(250);

                // Configure many-to-one relationship with ProductsCategory
                entity.HasOne(p => p.Category)
                    .WithMany(c => c.Products)
                    .HasForeignKey(p => p.CategoryId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            // ProductsCategory Entity Configuration
            modelBuilder.Entity<ProductsCategory>(entity =>
            {
                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            // Order Entity Configuration
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

                // Configure many-to-one relationship with User
                // This is already configured in the User entity, but reinforcing here
                entity.HasOne(o => o.User)
                    .WithMany(u => u.Orders)
                    .HasForeignKey(o => o.UserId)
                    .OnDelete(DeleteBehavior.Cascade);

                // Configure one-to-one relationship with Cart
                entity.HasOne(o => o.Cart)
                    .WithOne(c => c.Order)
                    .HasForeignKey<Order>(o => o.CartId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            // Cart Entity Configuration
            modelBuilder.Entity<Cart>(entity =>
            {
                // The one-to-one relationship with User is configured in the User entity

                // One-to-one relationship with Order
                entity.HasOne(c => c.Order)
                    .WithOne(o => o.Cart)
                    .HasForeignKey<Cart>(c => c.OrderId)
                    .OnDelete(DeleteBehavior.Cascade);

                // Configure the relationship with CartItems
                entity.HasMany(c => c.CartItems)
                    .WithOne(ci => ci.Cart)
                    .HasForeignKey(ci => ci.CartId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            // CartItem Entity Configuration
            modelBuilder.Entity<CartItem>(entity =>
            {
                entity.HasKey(ci => new { ci.CartId, ci.ProductId });

                entity.HasOne(ci => ci.Cart)
                    .WithMany(c => c.CartItems)
                    .HasForeignKey(ci => ci.CartId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(ci => ci.Product)
                    .WithMany(p => p.CartProducts)
                    .HasForeignKey(ci => ci.ProductId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.Property(ci => ci.Quantity)
                    .IsRequired();
                //Unrequired properties for CartItem are dropped here
                entity.Ignore(ci => ci.Id);
                entity.Ignore(ci => ci.CreatedDate);
                entity.Ignore(ci => ci.UpdatedDate);
            });

            base.OnModelCreating(modelBuilder);
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            // ChangeTracker: Tracks entities for auditing
            var entries = ChangeTracker.Entries<BaseEntity>();

            foreach (var entry in entries)
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedDate = DateTime.UtcNow;

                        if (entry.Entity is User user && !string.IsNullOrWhiteSpace(user.Password))
                        {
                            user.Password = PasswordHasher.HashPassword(user.Password);
                        }
                        break;
                          
                    case EntityState.Modified:
                        entry.Entity.UpdatedDate = DateTime.UtcNow;

                        if (entry.Entity is User modifiedUser && !string.IsNullOrWhiteSpace(modifiedUser.Password))
                        {
                            modifiedUser.Password = PasswordHasher.HashPassword(modifiedUser.Password);
                        }
                        break;
                }
            }

            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
