using Domain;
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

                entity.HasMany(p => p.CartItems)
                    .WithMany(c => c.Product);
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
                entity.HasOne(o => o.User)
                    .WithMany(u => u.Orders)
                    .HasForeignKey(o => o.UserId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(o => o.Cart)
                    .WithOne(c => c.Order)
                    .HasForeignKey<Order>(o => o.CartId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            // Cart Entity Configuration
            modelBuilder.Entity<Cart>(entity =>
            {
                // One-to-one relationship with User
                entity.HasOne(c => c.User)
                    .WithOne(u => u.Cart)
                    .HasForeignKey<Cart>(c => c.UserId)
                    .OnDelete(DeleteBehavior.Cascade);

                // One-to-one relation with Order, make it optional (OrderId nullable)
                entity.HasOne(c => c.Order)
                    .WithOne(o => o.Cart)
                    .HasForeignKey<Cart>(c => c.OrderId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasMany(c => c.Product)
                    .WithMany(p => p.CartItems);                
            });         

            // Db Seed
            base.OnModelCreating(modelBuilder);
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            // ChangeTracker: Track edilen verileri yakalayarak elde etmemizi sağlar. Interceptor olarak, Entity'ler üzerinde yapılan değişiklikleri ya da yeni eklenen verinin yakalanmasını sağlar.
            var datas = ChangeTracker
                .Entries<BaseEntity>();

            foreach (var data in datas)
            {
                switch (data.State)
                {
                    case EntityState.Added:
                        data.Entity.CreatedDate = DateTime.UtcNow;
                        if (data.Entity is User user && !string.IsNullOrWhiteSpace(user.Password))
                        {
                            user.Password = PasswordHasher.HashPassword(user.Password);
                        }
                        break;

                    case EntityState.Modified:
                        data.Entity.UpdatedDate = DateTime.UtcNow;
                        if (data.Entity is User modifiedUser && !string.IsNullOrWhiteSpace(modifiedUser.Password))
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
