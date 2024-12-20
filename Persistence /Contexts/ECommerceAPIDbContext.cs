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
        public DbSet<ProductDetail> ProductDetail { get; set; }
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

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Role)
                    .IsRequired();

                entity.Property(e => e.Country)
                    .HasConversion<string>() // Convert UserCountry enum to string
                    .IsRequired();

                entity.Property(e => e.PaymentCurrency)
                    .HasConversion<string>() // Convert PaymentCurrency enum to string
                    .IsRequired();

                entity.HasMany(u => u.Orders)
                    .WithOne(o => o.User)
                    .HasForeignKey(o => o.UserId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasMany(u => u.Cart)
                    .WithOne(c => c.User)
                    .HasForeignKey(c => c.UserId)
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

                entity.Property(e => e.TotalSold)
                    .HasDefaultValue(0);

                entity.Property(e => e.IsActive)
                    .IsRequired();

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

                entity.Property(e => e.IsActive)
                    .IsRequired();
            });

            modelBuilder.Entity<ProductDetail>(entity =>
            {
                entity.HasKey(pd => pd.ProductId );

                entity.Property(pd => pd.ProductDetail1)
                    .HasMaxLength(100);

                entity.Property(pd => pd.ProductDetail2)
                    .HasMaxLength(100);

                entity.Property(pd => pd.ProductDetail3)
                    .HasMaxLength(100);

                entity.HasOne(pd => pd.Product)
                    .WithOne(p => p.ProductDetail)
                    .HasForeignKey<ProductDetail>(pd => pd.ProductId) // Corrected Foreign Key
                    .OnDelete(DeleteBehavior.Cascade);
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
                    .HasConversion<string>() // Convert OrderStatus enum to string
                    .IsRequired();

                entity.Property(e => e.PaymentCurrency)
                    .HasConversion<string>() // Convert PaymentCurrency enum to string
                    .IsRequired();

                entity.Property(e => e.PaymentStatus)
                    .HasConversion<string>() // Convert PaymentStatus enum to string
                    .IsRequired();

                entity.HasOne(o => o.Cart)
                    .WithOne(c => c.Order)
                    .HasForeignKey<Order>(o => o.CartId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            // Cart Entity Configuration
            modelBuilder.Entity<Cart>(entity =>
            {
                entity.HasOne(c => c.Order)
                    .WithOne(o => o.Cart)
                    .HasForeignKey<Cart>(c => c.OrderId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasMany(c => c.CartItems)
                    .WithOne(ci => ci.Cart)
                    .HasForeignKey(ci => ci.CartId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.Property(c => c.IsModifyable)
                    .IsRequired()
                    .HasDefaultValue(true);

                entity.Property(c => c.Note)
                    .HasMaxLength(500);
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
                        entry.Entity.UpdatedDate = DateTime.UnixEpoch;

                        if (entry.Entity is User user && !string.IsNullOrWhiteSpace(user.Password))
                        {
                            user.Password = PasswordHasher.HashPassword(user.Password);
                        }
                      
                        break;
                          
                    case EntityState.Modified:
                        entry.Entity.CreatedDate = DateTime.UnixEpoch;
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
