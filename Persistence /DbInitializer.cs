using Domain;
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
                var soupyId = Guid.NewGuid();

                await dbContext.Users.AddRangeAsync(
                    new User
                    {
                        Id = berkeId,
                        Name = "Berke",
                        Surname = "Öztürk",
                        Email = "berkeozturk@mail.com",
                        Password =  "password1",
                        Role = true,
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },                  
                    new User
                    {
                        Id = soupyId,
                        Name = "Suphi Erkin",
                        Surname = "Karaçay",
                        Email = "serpinkaratay@mail.com",
                        Password =  "password3",
                        Role = false,
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    }
                );
                await dbContext.SaveChangesAsync();
            }

            // Seed Categories
            if (!await dbContext.Categories.AnyAsync())
            {
                var electronicsCategoryId = Guid.NewGuid();
                var booksCategoryId = Guid.NewGuid();

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
                        CategoryId = await dbContext.Categories.Where(c => c.CategoryName == "Electronics").Select(c => c.Id).FirstAsync(),
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
                        CategoryId = await dbContext.Categories.Where(c => c.CategoryName == "Electronics").Select(c => c.Id).FirstAsync(),
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Product
                    {
                        Id = bookAId,
                        Name = "Book A",
                        Stock = 200,
                        Price = 19.99,
                        Description = "An interesting novel",
                        ImageUrl = "/images/booka.jpg",
                        CategoryId = await dbContext.Categories.Where(c => c.CategoryName == "Books").Select(c => c.Id).FirstAsync(),
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    }
                );
                await dbContext.SaveChangesAsync();
            }

            // Seed Carts and CartItems
            if (!await dbContext.Carts.AnyAsync())
            {
                var berkeUser = await dbContext.Users.FirstOrDefaultAsync(u => u.Email == "berkeozturk@mail.com");
                var erkinUser = await dbContext.Users.FirstOrDefaultAsync(u => u.Email == "serpinkaratay@mail.com");

                var smartphone = await dbContext.Products.FirstOrDefaultAsync(p => p.Name == "Smartphone");
                var bookA = await dbContext.Products.FirstOrDefaultAsync(p => p.Name == "Book A");

                // Create carts for users
                var berkeCart = new Cart
                {
                    Id = Guid.NewGuid(),
                    UserId = berkeUser.Id,
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow,
                    CartItems = new List<CartItem>()
                };

                var erkinCart = new Cart
                {
                    Id = Guid.NewGuid(),
                    UserId = erkinUser.Id,
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow,
                    CartItems = new List<CartItem>()
                };

                // Add CartItems to carts
                berkeCart.CartItems.Add(new CartItem
                {
                    CartId = berkeCart.Id,
                    ProductId = smartphone.Id,
                    Quantity = 2
                });

                erkinCart.CartItems.Add(new CartItem
                {
                    CartId = erkinCart.Id,
                    ProductId = bookA.Id,
                    Quantity = 1
                });

                // Add carts to the database
                await dbContext.Carts.AddRangeAsync(berkeCart, erkinCart);
                await dbContext.SaveChangesAsync();
            }

            // Seed Orders
            if (!await dbContext.Orders.AnyAsync())
            {
                var berkeUser = await dbContext.Users.FirstOrDefaultAsync(u => u.Email == "berkeozturk@mail.com");
                var erkinUser = await dbContext.Users.FirstOrDefaultAsync(u => u.Email == "serpinkaratay@mail.com");

                var berkeCart = await dbContext.Carts.FirstOrDefaultAsync(c => c.UserId == berkeUser.Id);
                var erkinCart = await dbContext.Carts.FirstOrDefaultAsync(c => c.UserId == erkinUser.Id);

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
                        UserId = erkinUser.Id,
                        CartId = erkinCart.Id,
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
