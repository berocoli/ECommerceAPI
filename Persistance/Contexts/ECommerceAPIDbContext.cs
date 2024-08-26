﻿using System;
using Application.Exceptions;
using Domain;
using Domain.Entities.BaseEntity;
using Infrastructure.Operations;
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
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            DbInitializer.SeedModel(modelBuilder);

            // Additional configurations for each entity
            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(20);
                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(256);
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
                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(250);
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
                switch(data.State)
                {
                    case EntityState.Added:
                        data.Entity.CreatedDate = DateTime.UtcNow;
                        if(data.Entity is User User && !string.IsNullOrWhiteSpace(User.Password))
                        {
                            User.Password = PasswordHasher.HashPassword(User.Password);
                        }
                        break;
                    case EntityState.Modified:
                        data.Entity.UpdatedDate = DateTime.UtcNow;
                        if(data.Entity is User modifiedUser && !string.IsNullOrWhiteSpace(modifiedUser.Password))
                        {
                            modifiedUser.Password = PasswordHasher.HashPassword(modifiedUser.Password);
                        }
                        break;
                    case EntityState.Unchanged:
                    case EntityState.Deleted:
                    case EntityState.Detached:
                    data.Entity.UpdatedDate = data.Entity.UpdatedDate;
                    break;
                };
            }
            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}

