using System;
using System.Threading.Tasks;
using Domain;
using Infrastructure.Operations;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;

namespace Persistence.Seed
{
    public static class DbInitializer
    {
        public static async Task SeedAsync(ECommerceAPIDbContext dbContext)
        {
            // Ensure the database is created
            await dbContext.Database.EnsureCreatedAsync();

            // Seed Users
            if (!await dbContext.Users.AnyAsync())
            {
                var berkeId = Guid.NewGuid();
                var dogaId = Guid.NewGuid();
                var soupyId = Guid.NewGuid();

                await dbContext.Users.AddRangeAsync(
                    new User
                    {
                        Id = berkeId,
                        Name = "Berke",
                        Surname = "Öztürk",
                        Email = "berkeozturk@mail.com",
                        Password = PasswordHasher.HashPassword("hashedpassword1"),
                        Role = true,
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new User
                    {
                        Id = dogaId,
                        Name = "Doğa Su",
                        Surname = "Türkileri",
                        Email = "dogasuturkileri@mail.com",
                        Password = PasswordHasher.HashPassword("hashedpassword2"),
                        Role = false,
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new User
                    {
                        Id = soupyId,
                        Name = "Soupy Serpin",
                        Surname = "Karasay",
                        Email = "serpinkaratay@mail.com",
                        Password = PasswordHasher.HashPassword("hashedpw3"),
                        Role = false,
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    }
                );
                await dbContext.SaveChangesAsync();
            }

            // Seed Categories
            var electronicsCategoryId = Guid.NewGuid();
            var booksCategoryId = Guid.NewGuid();

            if (!await dbContext.Categories.AnyAsync())
            {
                await dbContext.Categories.AddRangeAsync(
                    new ProductsCategory
                    {
                        Id = electronicsCategoryId,
                        CategoryName = "Electronics",
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new ProductsCategory
                    {
                        Id = booksCategoryId,
                        CategoryName = "Books",
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    }
                );
                await dbContext.SaveChangesAsync();
            }

            // Seed Products
            if (!await dbContext.Products.AnyAsync())
            {
                var smartphoneId = Guid.NewGuid();
                var laptopId = Guid.NewGuid();
                var bookAId = Guid.NewGuid();

                await dbContext.Products.AddRangeAsync(
                    new Product
                    {
                        Id = smartphoneId,
                        Name = "Smartphone",
                        Stock = 100,
                        Price = 599.99,
                        Description = "Latest smartphone model",
                        ImageUrl = "/images/smartphone.jpg",
                        CategoryId = electronicsCategoryId,
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Product
                    {
                        Id = laptopId,
                        Name = "Laptop",
                        Stock = 50,
                        Price = 1099.99,
                        Description = "High-performance laptop",
                        ImageUrl = "/images/laptop.jpg",
                        CategoryId = electronicsCategoryId,
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Product
                    {
                        Id = bookAId,
                        Name = "Book A",
                        Stock = 200,
                        Price = 19.99,
                        Description = "Interesting novel",
                        ImageUrl = "/images/booka.jpg",
                        CategoryId = booksCategoryId,
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    }
                );
                await dbContext.SaveChangesAsync();
            }

            // Seed Carts
            if (!await dbContext.Carts.AnyAsync())
            {
                var smartphone = await dbContext.Products.FirstOrDefaultAsync(p => p.Name == "Smartphone");
                var bookA = await dbContext.Products.FirstOrDefaultAsync(p => p.Name == "Book A");

                var berkeUser = await dbContext.Users.FirstOrDefaultAsync(u => u.Email == "berkeozturk@mail.com");
                var dogaUser = await dbContext.Users.FirstOrDefaultAsync(u => u.Email == "dogasuturkileri@mail.com");

                await dbContext.Carts.AddRangeAsync(
                    new Cart
                    {
                        Id = Guid.NewGuid(),
                        UserId = berkeUser.Id,
                        Product = new List<Product> { smartphone },
                        Quantity = 2, // Berke ordered 2 smartphones
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Cart
                    {
                        Id = Guid.NewGuid(),
                        UserId = dogaUser.Id,
                        Product = new List<Product> { bookA },
                        Quantity = 1, // Doğa ordered 1 book
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    }
                );
                await dbContext.SaveChangesAsync();
            }

            // Seed Orders
            if (!await dbContext.Orders.AnyAsync())
            {
                var berkeUser = await dbContext.Users.FirstOrDefaultAsync(u => u.Email == "berkeozturk@mail.com");
                var dogaUser = await dbContext.Users.FirstOrDefaultAsync(u => u.Email == "dogasuturkileri@mail.com");

                var berkeCart = await dbContext.Carts.FirstOrDefaultAsync(c => c.UserId == berkeUser.Id);
                var dogaCart = await dbContext.Carts.FirstOrDefaultAsync(c => c.UserId == dogaUser.Id);

                await dbContext.Orders.AddRangeAsync(
                    new Order
                    {
                        Id = Guid.NewGuid(),
                        UserId = berkeUser.Id,
                        CartId = berkeCart.Id,
                        Address = "123 Main St",
                        Description = "Deliver ASAP",
                        Status = "Pending",
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Order
                    {
                        Id = Guid.NewGuid(),
                        UserId = dogaUser.Id,
                        CartId = dogaCart.Id,
                        Address = "456 Elm St",
                        Description = "Gift order",
                        Status = "Shipped",
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    }
                );
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
