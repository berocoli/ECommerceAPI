using Domain;
using Domain.Entities.BaseEntity;
using Domain.Enums;
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

            await using var transaction = await dbContext.Database.BeginTransactionAsync();

            try
            {
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
                            Password = "password1",
                            PhoneNumber = "+905535532698",
                            Country = UserCountry.Turkey,
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
                            Password = "password2",
                            PhoneNumber = "+901234123412",
                            Country = UserCountry.Turkey,
                            Role = false,
                            
                            CreatedDate = DateTime.UtcNow,
                            UpdatedDate = DateTime.UtcNow
                        }
                    );
                    await dbContext.SaveChangesAsync();
                }

                // Seed Categories
                // Seed Categories
                if (!await dbContext.Categories.AnyAsync())
                {
                    var sportsCategoryId = Guid.NewGuid();
                    var homeCategoryId = Guid.NewGuid();
                    var accessoriesCategoryId = Guid.NewGuid();
                    var electronicsCategoryId = Guid.NewGuid();
                    var furnitureCategoryId = Guid.NewGuid();
                    var instrumentsCategoryId = Guid.NewGuid();
                    var booksCategoryId = Guid.NewGuid();

                    var categories = new List<ProductsCategory>
                    {
                        new ProductsCategory
                        {
                            Id = sportsCategoryId,
                            CategoryName = "Sports",
                            IsActive = true,
                            CreatedDate = DateTime.UtcNow,
                            UpdatedDate = DateTime.UtcNow
                        },
                        new ProductsCategory
                        {
                            Id = homeCategoryId,
                            CategoryName = "Home",
                            IsActive = true,
                            CreatedDate = DateTime.UtcNow,
                            UpdatedDate = DateTime.UtcNow
                        },
                        new ProductsCategory
                        {
                            Id = accessoriesCategoryId,
                            CategoryName = "Accessories",
                            IsActive = true,
                            CreatedDate = DateTime.UtcNow,
                            UpdatedDate = DateTime.UtcNow
                        },
                        new ProductsCategory
                        {
                            Id = electronicsCategoryId,
                            CategoryName = "Electronics",
                            IsActive = true,
                            CreatedDate = DateTime.UtcNow,
                            UpdatedDate = DateTime.UtcNow
                        },
                        new ProductsCategory
                        {
                            Id = furnitureCategoryId,
                            CategoryName = "Furniture",
                            IsActive = true,
                            CreatedDate = DateTime.UtcNow,
                            UpdatedDate = DateTime.UtcNow
                        },
                        new ProductsCategory
                        {
                            Id = instrumentsCategoryId,
                            CategoryName = "Instruments",
                            IsActive = false,
                            CreatedDate = DateTime.UtcNow,
                            UpdatedDate = DateTime.UtcNow
                        },
                            new ProductsCategory
                        {
                            Id = booksCategoryId,
                            CategoryName = "Books",
                            IsActive = true,
                            CreatedDate = DateTime.UtcNow,
                                UpdatedDate = DateTime.UtcNow }
                        };

                            await dbContext.Categories.AddRangeAsync(categories);
                            await dbContext.SaveChangesAsync();
                }

                // Seed Products
                if (!await dbContext.Products.AnyAsync())
                {
                    var berkeId = await dbContext.Users.Where(u => u.Email == "berkeozturk@mail.com").Select(u => u.Id).FirstAsync();

                    await dbContext.Products.AddRangeAsync(
                        new Product
                        {
                            Id = Guid.NewGuid(),
                            Name = "Smartphone",
                            Stock = 100,
                            Price = 599.99,
                            Description = "Latest smartphone model",
                            ImageUrl = "smartphone.jpg",
                            CategoryId = await dbContext.Categories.Where(c => c.CategoryName == "Electronics").Select(c => c.Id).FirstAsync(),                           
                            IsActive = true,
                            TotalSold = 0,
                            CreatedDate = DateTime.UtcNow,
                            UpdatedDate = DateTime.UtcNow
                        },
                        new Product
                        {
                            Id = Guid.NewGuid(),
                            Name = "Laptop",
                            Stock = 50,
                            Price = 1099.99,
                            Description = "High-performance laptop",
                            ImageUrl = "laptop.jpg",
                            CategoryId = await dbContext.Categories.Where(c => c.CategoryName == "Electronics").Select(c => c.Id).FirstAsync(),                           
                            IsActive = true,
                            TotalSold = 0,
                            CreatedDate = DateTime.UtcNow,
                            UpdatedDate = DateTime.UtcNow
                        },
                        new Product
                        {
                            Id = Guid.NewGuid(),
                            Name = "Book A",
                            Stock = 200,
                            Price = 19.99,
                            Description = "An interesting novel",
                            ImageUrl = "booka.jpg",
                            CategoryId = await dbContext.Categories.Where(c => c.CategoryName == "Books").Select(c => c.Id).FirstAsync(),                            
                            IsActive = true,
                            TotalSold = 0,
                            CreatedDate = DateTime.UtcNow,
                            UpdatedDate = DateTime.UtcNow
                        },
                        new Product
                        {
                            Id = Guid.NewGuid(),
                            Name = "Headphones",
                            Stock = 150,
                            Price = 89.99,
                            Description = "Noise-cancelling over-ear headphones",
                            ImageUrl = "headphones.jpg",
                            CategoryId = await dbContext.Categories.Where(c => c.CategoryName == "Electronics").Select(c => c.Id).FirstAsync(),                           
                            IsActive = true,
                            TotalSold = 0,
                            CreatedDate = DateTime.UtcNow,
                            UpdatedDate = DateTime.UtcNow
                        },
                        new Product
                        {
                            Id = Guid.NewGuid(),
                            Name = "Tablet",
                            Stock = 70,
                            Price = 299.99,
                            Description = "Portable and powerful tablet device",
                            ImageUrl = "tablet.jpg",
                            CategoryId = await dbContext.Categories.Where(c => c.CategoryName == "Electronics").Select(c => c.Id).FirstAsync(),                           
                            IsActive = true,
                            TotalSold = 0,
                            CreatedDate = DateTime.UtcNow,
                            UpdatedDate = DateTime.UtcNow
                        },
                        new Product
                        {
                            Id = Guid.NewGuid(),
                            Name = "Desk Lamp",
                            Stock = 120,
                            Price = 29.99,
                            Description = "Stylish LED desk lamp",
                            ImageUrl = "desklamp.jpg",
                            CategoryId = await dbContext.Categories.Where(c => c.CategoryName == "Home").Select(c => c.Id).FirstAsync(),                           
                            IsActive = true,
                            TotalSold = 0,
                            CreatedDate = DateTime.UtcNow,
                            UpdatedDate = DateTime.UtcNow
                        },
                        new Product
                        {
                            Id = Guid.NewGuid(),
                            Name = "Office Chair",
                            Stock = 80,
                            Price = 199.99,
                            Description = "Ergonomic office chair with adjustable height",
                            ImageUrl = "officechair.jpg",
                            CategoryId = await dbContext.Categories.Where(c => c.CategoryName == "Furniture").Select(c => c.Id).FirstAsync(),                            
                            IsActive = true,
                            TotalSold = 0,
                            CreatedDate = DateTime.UtcNow,
                            UpdatedDate = DateTime.UtcNow
                        },
                        new Product
                        {
                            Id = Guid.NewGuid(),
                            Name = "Coffee Table",
                            Stock = 40,
                            Price = 149.99,
                            Description = "Modern wooden coffee table",
                            ImageUrl = "coffeetable.jpg",
                            CategoryId = await dbContext.Categories.Where(c => c.CategoryName == "Furniture").Select(c => c.Id).FirstAsync(),                           
                            IsActive = true,
                            TotalSold = 0,
                            CreatedDate = DateTime.UtcNow,
                            UpdatedDate = DateTime.UtcNow
                        },
                        new Product
                        {
                            Id = Guid.NewGuid(),
                            Name = "Running Shoes",
                            Stock = 90,
                            Price = 79.99,
                            Description = "Lightweight running shoes",
                            ImageUrl = "runningshoes.jpg",
                            CategoryId = await dbContext.Categories.Where(c => c.CategoryName == "Sports").Select(c => c.Id).FirstAsync(),                            
                            IsActive = true,
                            TotalSold = 0,
                            CreatedDate = DateTime.UtcNow,
                            UpdatedDate = DateTime.UtcNow
                        },
                        new Product
                        {
                            Id = Guid.NewGuid(),
                            Name = "Yoga Mat",
                            Stock = 100,
                            Price = 24.99,
                            Description = "Non-slip yoga mat",
                            ImageUrl = "yogamat.jpg",
                            CategoryId = await dbContext.Categories.Where(c => c.CategoryName == "Sports").Select(c => c.Id).FirstAsync(),
                            IsActive = true,
                            TotalSold = 0,
                            CreatedDate = DateTime.UtcNow,
                            UpdatedDate = DateTime.UtcNow
                        },
                        new Product
                        {
                            Id = Guid.NewGuid(),
                            Name = "Backpack",
                            Stock = 60,
                            Price = 49.99,
                            Description = "Durable travel backpack",
                            ImageUrl = "backpack.jpg",
                            CategoryId = await dbContext.Categories.Where(c => c.CategoryName == "Accessories").Select(c => c.Id).FirstAsync(),                            
                            IsActive = true,
                            TotalSold = 0,
                            CreatedDate = DateTime.UtcNow,
                            UpdatedDate = DateTime.UtcNow
                        }
                    );
                    await dbContext.SaveChangesAsync();
                }

                // Seed ProductDetails
                if (!await dbContext.Set<ProductDetail>().AnyAsync())
                {
                    var products = await dbContext.Products.ToListAsync();

                    var productDetails = new List<ProductDetail>
                    {
                        new ProductDetail
                        {
                            Id = Guid.NewGuid(),
                            ProductId = products.FirstOrDefault(p => p.Name == "Smartphone")?.Id ?? Guid.NewGuid(),
                            ProductDetail1 = "High-end smartphone with excellent performance.",
                            ProductDetail2 = "Features a sleek design and robust build quality.",
                            ProductDetail3 = "Includes a one-year warranty for peace of mind.",
                            CreatedDate = DateTime.UtcNow,
                            UpdatedDate = DateTime.UtcNow
                        },
                        new ProductDetail
                        {
                            Id = Guid.NewGuid(),
                            ProductId = products.FirstOrDefault(p => p.Name == "Laptop")?.Id ?? Guid.NewGuid(),
                            ProductDetail1 = "Powerful laptop suitable for gaming and work.",
                            ProductDetail2 = "Equipped with the latest generation processors.",
                            ProductDetail3 = "Lightweight design with extended battery life.",
                            CreatedDate = DateTime.UtcNow,
                            UpdatedDate = DateTime.UtcNow
                        },
                        new ProductDetail
                        {
                            Id = Guid.NewGuid(),
                            ProductId = products.FirstOrDefault(p => p.Name == "Book A")?.Id ?? Guid.NewGuid(),
                            ProductDetail1 = "Captivating story with intricate characters.",
                            ProductDetail2 = "Perfect for book lovers of all ages.",
                            ProductDetail3 = "A must-read for this year.",
                            CreatedDate = DateTime.UtcNow,
                            UpdatedDate = DateTime.UtcNow
                        },
                        new ProductDetail
                        {
                            Id = Guid.NewGuid(),
                            ProductId = products.FirstOrDefault(p => p.Name == "Headphones")?.Id ?? Guid.NewGuid(),
                            ProductDetail1 = "Noise-canceling headphones with superior sound quality.",
                            ProductDetail2 = "Comfortable over-ear design for long hours of use.",
                            ProductDetail3 = "Supports both wired and wireless connectivity.",
                            CreatedDate = DateTime.UtcNow,
                            UpdatedDate = DateTime.UtcNow
                        },
                        new ProductDetail
                        {
                            Id = Guid.NewGuid(),
                            ProductId = products.FirstOrDefault(p => p.Name == "Tablet")?.Id ?? Guid.NewGuid(),
                            ProductDetail1 = "Portable tablet with a vibrant display.",
                            ProductDetail2 = "Ideal for both productivity and entertainment.",
                            ProductDetail3 = "Long-lasting battery life with quick charging support.",
                            CreatedDate = DateTime.UtcNow,
                            UpdatedDate = DateTime.UtcNow
                        },
                        new ProductDetail
                        {
                            Id = Guid.NewGuid(),
                            ProductId = products.FirstOrDefault(p => p.Name == "Desk Lamp")?.Id ?? Guid.NewGuid(),
                            ProductDetail1 = "Energy-efficient LED desk lamp.",
                            ProductDetail2 = "Adjustable brightness levels for any environment.",
                            ProductDetail3 = "Modern design that complements your workspace.",
                            CreatedDate = DateTime.UtcNow,
                            UpdatedDate = DateTime.UtcNow
                        },
                        new ProductDetail
                        {
                            Id = Guid.NewGuid(),
                            ProductId = products.FirstOrDefault(p => p.Name == "Office Chair")?.Id ?? Guid.NewGuid(),
                            ProductDetail1 = "Ergonomic office chair for maximum comfort.",
                            ProductDetail2 = "Adjustable height and reclining features.",
                            ProductDetail3 = "Durable build with premium materials.",
                            CreatedDate = DateTime.UtcNow,
                            UpdatedDate = DateTime.UtcNow
                        },
                        new ProductDetail
                        {
                            Id = Guid.NewGuid(),
                            ProductId = products.FirstOrDefault(p => p.Name == "Coffee Table")?.Id ?? Guid.NewGuid(),
                            ProductDetail1 = "Stylish coffee table made of high-quality wood.",
                            ProductDetail2 = "Perfect addition to your living room decor.",
                            ProductDetail3 = "Sturdy and easy to maintain.",
                            CreatedDate = DateTime.UtcNow,
                            UpdatedDate = DateTime.UtcNow
                        },
                        new ProductDetail
                        {
                            Id = Guid.NewGuid(),
                            ProductId = products.FirstOrDefault(p => p.Name == "Running Shoes")?.Id ?? Guid.NewGuid(),
                            ProductDetail1 = "Lightweight running shoes for everyday use.",
                            ProductDetail2 = "Provides excellent grip and support.",
                            ProductDetail3 = "Available in multiple sizes and colors.",
                            CreatedDate = DateTime.UtcNow,
                            UpdatedDate = DateTime.UtcNow
                        },
                        new ProductDetail
                        {
                            Id = Guid.NewGuid(),
                            ProductId = products.FirstOrDefault(p => p.Name == "Yoga Mat")?.Id ?? Guid.NewGuid(),
                            ProductDetail1 = "Non-slip yoga mat for added safety.",
                            ProductDetail2 = "Thick cushioning for maximum comfort.",
                            ProductDetail3 = "Durable and easy to clean.",
                            CreatedDate = DateTime.UtcNow,
                            UpdatedDate = DateTime.UtcNow
                        },
                        new ProductDetail
                        {
                            Id = Guid.NewGuid(),
                            ProductId = products.FirstOrDefault(p => p.Name == "Backpack")?.Id ?? Guid.NewGuid(),
                            ProductDetail1 = "Durable backpack for travel and everyday use.",
                            ProductDetail2 = "Ample storage space with multiple compartments.",
                            ProductDetail3 = "Water-resistant material for added protection.",
                            CreatedDate = DateTime.UtcNow,
                            UpdatedDate = DateTime.UtcNow
                        }
                    };

                    await dbContext.Set<ProductDetail>().AddRangeAsync(productDetails);
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
                        IsModifyable = true, // Allow modifications initially
                        Note = "Berke's cart for testing purposes", // Example note property
                        CartItems = new List<CartItem>()
                    };

                    var erkinCart = new Cart
                    {
                        Id = Guid.NewGuid(),
                        UserId = erkinUser.Id,
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow,
                        IsModifyable = true,
                        Note = "Erkin's cart for testing purposes",
                        CartItems = new List<CartItem>()
                    };

                    // Add CartItems to carts
                    berkeCart.CartItems.Add(new CartItem
                    {
                        CartId = berkeCart.Id,
                        ProductId = smartphone.Id,
                        Quantity = 2,
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    });

                    erkinCart.CartItems.Add(new CartItem
                    {
                        CartId = erkinCart.Id,
                        ProductId = bookA.Id,
                        Quantity = 1,
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
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

                    // Generate Order Numbers
                    
                    await dbContext.Orders.AddRangeAsync(
                        new Order
                        {
                            Id = Guid.NewGuid(),
                            UserId = berkeUser.Id,
                            CartId = berkeCart.Id,
                            Address = "123 Main St",
                            Description = "Deliver ASAP",
                            Status = OrderStatus.SeedData,
                            PaymentCurrency = PaymentCurrency.USD, // Added PaymentCurrency
                            PaymentStatus = PaymentStatus.Captured, // Added PaymentStatus
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
                            Status = OrderStatus.SeedData,
                            PaymentCurrency = PaymentCurrency.EUR, // Added PaymentCurrency
                            PaymentStatus = PaymentStatus.Pending, // Added PaymentStatus
                            CreatedDate = DateTime.UtcNow,
                            UpdatedDate = DateTime.UtcNow
                        }
                    );
                    await dbContext.SaveChangesAsync();
                }

                await transaction.CommitAsync();
            }
            catch (Exception)
            {
                await transaction.RollbackAsync();
                throw;
            }
        }
    }
}