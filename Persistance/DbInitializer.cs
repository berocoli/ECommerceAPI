using Domain;
using Microsoft.EntityFrameworkCore;
using Persistance.Contexts;

namespace Persistance
{
    // Database Seeder Class
    public class DbInitializer
    {
        private readonly ECommerceAPIDbContext dbContext;
        private readonly ModelBuilder modelBuilder;

        public DbInitializer(ECommerceAPIDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        // Method to seed model data during OnModelCreating
        public static void SeedModel(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                    new Customer()
                    {
                        Id = Guid.NewGuid(),
                        Name = "Berke Öztürk",
                        Email = "example1@mail.com",
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Customer()
                    {
                        Id = Guid.NewGuid(),
                        Name = "Doğa Su Türkileri",
                        Email = "example2@mail.com",
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Customer()
                    {
                        Id = Guid.NewGuid(),
                        Name = "Ervin Parlak",
                        Email = "example3@mail.com",
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Customer()
                    {
                        Id = Guid.NewGuid(),
                        Name = "Gamze Naz Yıldırım",
                        Email = "example4@mail.com",
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Customer()
                    {
                        Id = Guid.NewGuid(),
                        Name = "Atakan Yıldırım",
                        Email = "example5@mail.com",
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Customer()
                    {
                        Id = Guid.NewGuid(),
                        Name = "Ahmet Mümtaz Taylan",
                        Email = "example6@mail.com",
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Customer()
                    {
                        Id = Guid.NewGuid(),
                        Name = "Cem Yılmaz",
                        Email = "example7@mail.com",
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Customer()
                    {
                        Id = Guid.NewGuid(),
                        Name = "Şahan Gökbakar",
                        Email = "example8@mail.com",
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Customer()
                    {
                        Id = Guid.NewGuid(),
                        Name = "Mahsun Kırmızıgül",
                        Email = "example9@mail.com",
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Customer()
                    {
                        Id = Guid.NewGuid(),
                        Name = "Erkin Karaçay",
                        Email = "example10@mail.com",
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Customer()
                    {
                        Id = Guid.NewGuid(),
                        Name = "Ozan İmamhatipoğlu",
                        Email = "example11@mail.com",
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Customer()
                    {
                        Id = Guid.NewGuid(),
                        Name = "Barkın Özkaplan",
                        Email = "example12@mail.com",
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Customer()
                    {
                        Id = Guid.NewGuid(),
                        Name = "Barış Onur Aydın",
                        Email = "example13@mail.com",
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Customer()
                    {
                        Id = Guid.NewGuid(),
                        Name = "Deniz Zarshat",
                        Email = "example14@mail.com",
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    }
                    );
            modelBuilder.Entity<Order>().HasData(
                    new Order()
                    {
                        Id = Guid.NewGuid(),
                        CustomerId = Guid.NewGuid(),
                        Address = "2222 Oak Drive, Hillcrest, NY 10001",
                        Status = "Pending",
                        Description = " Please leave the package at the front porch if no one is home.",
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Order()
                    {
                        Id = Guid.NewGuid(),
                        CustomerId = Guid.NewGuid(),
                        Address = "456 Elm Avenue, Oakville, CA 94022",
                        Status = "Pending",
                        Description = " Please leave the package at the front porch if no one is home.",
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Order()
                    {
                        Id = Guid.NewGuid(),
                        CustomerId = Guid.NewGuid(),
                        Address = "10101 Juniper Avenue, Blue Ridge, NC 27501",
                        Status = "Pending",
                        Description = " Please leave the package at the front porch if no one is home.",
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Order()
                    {
                        Id = Guid.NewGuid(),
                        CustomerId = Guid.NewGuid(),
                        Address = "9999 Spruce Place, Highland, UT 84003",
                        Status = "Pending",
                        Description = " Please leave the package at the front porch if no one is home.",
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Order()
                    {
                        Id = Guid.NewGuid(),
                        CustomerId = Guid.NewGuid(),
                        Address = "4444 Aspen Court, Meadowbrook, OR 97001",
                        Status = "Pending",
                        Description = " Please leave the package at the front porch if no one is home.",
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Order()
                    {
                        Id = Guid.NewGuid(),
                        CustomerId = Guid.NewGuid(),
                        Address = "789 Pine Lane, Rivertown, TX 75001",
                        Status = "Pending",
                        Description = " Please leave the package at the front porch if no one is home.",
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Order()
                    {
                        Id = Guid.NewGuid(),
                        CustomerId = Guid.NewGuid(),
                        Address = "5555 Redwood Street, Greenfield, AZ 85001",
                        Status = "Pending",
                        Description = " Please leave the package at the front porch if no one is home.",
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Order()
                    {
                        Id = Guid.NewGuid(),
                        CustomerId = Guid.NewGuid(),
                        Address = "7777 Poplar Path, Brookhaven, GA 30301",
                        Status = "Pending",
                        Description = " Please leave the package at the front porch if no one is home.",
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Order()
                    {
                        Id = Guid.NewGuid(),
                        CustomerId = Guid.NewGuid(),
                        Address = "1010 Birch Road, Forestville, WA 98001",
                        Status = "Pending",
                        Description = " Please leave the package at the front porch if no one is home.",
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Order()
                    {
                        Id = Guid.NewGuid(),
                        CustomerId = Guid.NewGuid(),
                        Address = "8888 Cypress Circle, Riverview, MI 48201",
                        Status = "Pending",
                        Description = " Please leave the package at the front porch if no one is home.",
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    }
                );
            modelBuilder.Entity<Product>().HasData(
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        CategoryId = Guid.NewGuid(),
                        Name = "BirchCraft Office Chair",
                        Description = "An ergonomic office chair with adjustable height and lumbar support. Ideal for long hours of work.",
                        Price = 149.99,
                        Stock = 150,
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        CategoryId = Guid.NewGuid(),
                        Name = "OakHill Running Shoes",
                        Description = "Lightweight and comfortable running shoes with breathable mesh and cushioned sole.",
                        Price = 89.99,
                        Stock = 300,
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        CategoryId = Guid.NewGuid(),
                        Name = "WillowWave Bluetooth Speaker",
                        Description = "A portable Bluetooth speaker with high-quality sound and long battery life. Perfectforoutdooractivities.",
                        Price = 59.99,
                        Stock = 250,
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        CategoryId = Guid.NewGuid(),
                        Name = "AspenGlow LED Lamp",
                        Description = "A stylish LED lamp with adjustable brightness and color temperature. Ideal for reading and working.",
                        Price = 39.99,
                        Stock = 180,
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        CategoryId = Guid.NewGuid(),
                        Name = "RedwoodX Gaming Laptop",
                        Description = "A powerful gaming laptop with high-end graphics and fast processing speed. Ideal for gamers.",
                        Price = 1299.99,
                        Stock = 30,
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        CategoryId = Guid.NewGuid(),
                        Name = "FirNest Home Security Camera",
                        Description = "A smart home security camera with night vision and motion detection. Connects to your smartphone.",
                        Price = 99.99,
                        Stock = 100,
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        CategoryId = Guid.NewGuid(),
                        Name = "PoplarPulse Fitness Tracker",
                        Description = "A fitness tracker with heart rate monitoring, step counting, and sleep tracking. Waterproof design.",
                        Price = 49.99,
                        Stock = 220,
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        CategoryId = Guid.NewGuid(),
                        Name = "CypressFlow Yoga Mat",
                        Description = "A non-slip yoga mat with extra cushioning for comfort. Perfect for yoga and pilates.",
                        Price = 29.99,
                        Stock = 500,
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        CategoryId = Guid.NewGuid(),
                        Name = "SpruceSky Drone",
                        Description = "A high-performance drone with HD camera and long battery life. Ideal for aerial photography.",
                        Price = 349.99,
                        Stock = 60,
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        CategoryId = Guid.NewGuid(),
                        Name = "JuniperPure Water Bottle",
                        Description = "An insulated water bottle that keeps drinks hot or cold for hours. Made from stainless steel.",
                        Price = 24.99,
                        Stock = 400,
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        CategoryId = Guid.NewGuid(),
                        Name = "MapleFlex Smartphone Case",
                        Description = "A durable and flexible smartphone case that provides excellent protection. Compatible with most models.",
                        Price = 19.99,
                        Stock = 350,
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        CategoryId = Guid.NewGuid(),
                        Name = "ElmGlow Table Lamp",
                        Description = "A contemporary table lamp with touch control and adjustable brightness. Perfect for any room.",
                        Price = 34.99,
                        Stock = 140,
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        CategoryId = Guid.NewGuid(),
                        Name = "PineEdge Kitchen Knife Set",
                        Description = "A professional kitchen knife set with high-carbon stainless steel blades. Includes 6 knives and ablock.",
                        Price = 89.99,
                        Stock = 85,
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        CategoryId = Guid.NewGuid(),
                        Name = "BirchSound Wireless Earbuds",
                        Description = "High-quality wireless earbuds with noise cancellation and long battery life. Comes with a chargingcase.",
                        Price = 79.99,
                        Stock = 300,
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        CategoryId = Guid.NewGuid(),
                        Name = "OakPure Coffee Maker",
                        Description = "A programmable coffee maker with a built-in grinder and timer. Makes up to 12 cups of coffee.",
                        Price = 129.99,
                        Stock = 90,
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        CategoryId = Guid.NewGuid(),
                        Name = "WillowLite Camping Tent",
                        Description = "A lightweight and durable camping tent that accommodates up to 4 people. Easy to set up.",
                        Price = 199.99,
                        Stock = 70,
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        CategoryId = Guid.NewGuid(),
                        Name = "AspenCool Mini Fridge",
                        Description = "A compact mini fridge with adjustable temperature settings. Perfect for dorm rooms and offices.",
                        Price = 149.99,
                        Stock = 120,
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        CategoryId = Guid.NewGuid(),
                        Name = "RedwoodMax Power Bank",
                        Description = "A high-capacity power bank with fast charging technology. Compatible with all USB devices.",
                        Price = 39.99,
                        Stock = 250,
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    }
                );
        }
        public void SeedDatabase()
        {
            if (!dbContext.Customers.Any())
            {
                dbContext.AddRange(
                    new Customer()
                    {
                        Id = Guid.NewGuid(),
                        Name = "Berke Öztürk",
                        Email = "example1@mail.com",
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Customer
                    {
                        Id = Guid.NewGuid(),
                        Name = "Doğa Su Türkileri",
                        Email = "example2@mail.com",
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Customer()
                    {
                        Id = Guid.NewGuid(),
                        Name = "Ervin Parlak",
                        Email = "example3@mail.com",
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Customer()
                    {
                        Id = Guid.NewGuid(),
                        Name = "Gamze Naz Yıldırım",
                        Email = "example4@mail.com",
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Customer()
                    {
                        Id = Guid.NewGuid(),
                        Name = "Atakan Yıldırım",
                        Email = "example5@mail.com",
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Customer()
                    {
                        Id = Guid.NewGuid(),
                        Name = "Ahmet Mümtaz Taylan",
                        Email = "example6@mail.com",
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Customer()
                    {
                        Id = Guid.NewGuid(),
                        Name = "Cem Yılmaz",
                        Email = "example7@mail.com",
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Customer()
                    {
                        Id = Guid.NewGuid(),
                        Name = "Şahan Gökbakar",
                        Email = "example8@mail.com",
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Customer()
                    {
                        Id = Guid.NewGuid(),
                        Name = "Mahsun Kırmızıgül",
                        Email = "example9@mail.com",
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Customer()
                    {
                        Id = Guid.NewGuid(),
                        Name = "Erkin Karaçay",
                        Email = "example10@mail.com",
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Customer()
                    {
                        Id = Guid.NewGuid(),
                        Name = "Ozan İmamhatipoğlu",
                        Email = "example11@mail.com",
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Customer()
                    {
                        Id = Guid.NewGuid(),
                        Name = "Barkın Özkaplan",
                        Email = "example12@mail.com",
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Customer()
                    {
                        Id = Guid.NewGuid(),
                        Name = "Barış Onur Aydın",
                        Email = "example13@mail.com",
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Customer()
                    {
                        Id = Guid.NewGuid(),
                        Name = "Deniz Zarshat",
                        Email = "example14@mail.com",
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    }
                );
            }
            if (!dbContext.Orders.Any())
            {
                dbContext.AddRange(
                    new Order()
                    {
                        Id = Guid.NewGuid(),
                        CustomerId = Guid.NewGuid(),
                        Address = "2222 Oak Drive, Hillcrest, NY 10001",
                        Status = "Pending",
                        Description = " Please leave the package at the front porch if no one is home.",
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Order()
                    {
                        Id = Guid.NewGuid(),
                        CustomerId = Guid.NewGuid(),
                        Address = "456 Elm Avenue, Oakville, CA 94022",
                        Status = "Pending",
                        Description = " Please leave the package at the front porch if no one is home.",
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Order()
                    {
                        Id = Guid.NewGuid(),
                        CustomerId = Guid.NewGuid(),
                        Address = "10101 Juniper Avenue, Blue Ridge, NC 27501",
                        Status = "Pending",
                        Description = " Please leave the package at the front porch if no one is home.",
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Order()
                    {
                        Id = Guid.NewGuid(),
                        CustomerId = Guid.NewGuid(),
                        Address = "9999 Spruce Place, Highland, UT 84003",
                        Status = "Pending",
                        Description = " Please leave the package at the front porch if no one is home.",
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Order()
                    {
                        Id = Guid.NewGuid(),
                        CustomerId = Guid.NewGuid(),
                        Address = "4444 Aspen Court, Meadowbrook, OR 97001",
                        Status = "Pending",
                        Description = " Please leave the package at the front porch if no one is home.",
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Order()
                    {
                        Id = Guid.NewGuid(),
                        CustomerId = Guid.NewGuid(),
                        Address = "789 Pine Lane, Rivertown, TX 75001",
                        Status = "Pending",
                        Description = " Please leave the package at the front porch if no one is home.",
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Order()
                    {
                        Id = Guid.NewGuid(),
                        CustomerId = Guid.NewGuid(),
                        Address = "5555 Redwood Street, Greenfield, AZ 85001",
                        Status = "Pending",
                        Description = " Please leave the package at the front porch if no one is home.",
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Order()
                    {
                        Id = Guid.NewGuid(),
                        CustomerId = Guid.NewGuid(),
                        Address = "7777 Poplar Path, Brookhaven, GA 30301",
                        Status = "Pending",
                        Description = " Please leave the package at the front porch if no one is home.",
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Order()
                    {
                        Id = Guid.NewGuid(),
                        CustomerId = Guid.NewGuid(),
                        Address = "1010 Birch Road, Forestville, WA 98001",
                        Status = "Pending",
                        Description = " Please leave the package at the front porch if no one is home.",
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Order()
                    {
                        Id = Guid.NewGuid(),
                        CustomerId = Guid.NewGuid(),
                        Address = "8888 Cypress Circle, Riverview, MI 48201",
                        Status = "Pending",
                        Description = " Please leave the package at the front porch if no one is home.",
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    }
                );
            }
            if (!dbContext.Products.Any())
            {
                dbContext.AddRange(
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        CategoryId = Guid.NewGuid(),
                        Name = "BirchCraft Office Chair",
                        Description = "An ergonomic office chair with adjustable height and lumbar support. Ideal for long hours of work.",
                        Price = 149.99,
                        Stock = 150,
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        CategoryId = Guid.NewGuid(),
                        Name = "OakHill Running Shoes",
                        Description = "Lightweight and comfortable running shoes with breathable mesh and cushioned sole.",
                        Price = 89.99,
                        Stock = 300,
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        CategoryId = Guid.NewGuid(),
                        Name = "WillowWave Bluetooth Speaker",
                        Description = "A portable Bluetooth speaker with high-quality sound and long battery life. Perfectforoutdooractivities.",
                        Price = 59.99,
                        Stock = 250,
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        CategoryId = Guid.NewGuid(),
                        Name = "AspenGlow LED Lamp",
                        Description = "A stylish LED lamp with adjustable brightness and color temperature. Ideal for reading and working.",
                        Price = 39.99,
                        Stock = 180,
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        CategoryId = Guid.NewGuid(),
                        Name = "RedwoodX Gaming Laptop",
                        Description = "A powerful gaming laptop with high-end graphics and fast processing speed. Ideal for gamers.",
                        Price = 1299.99,
                        Stock = 30,
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        CategoryId = Guid.NewGuid(),
                        Name = "FirNest Home Security Camera",
                        Description = "A smart home security camera with night vision and motion detection. Connects to your smartphone.",
                        Price = 99.99,
                        Stock = 100,
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        CategoryId = Guid.NewGuid(),
                        Name = "PoplarPulse Fitness Tracker",
                        Description = "A fitness tracker with heart rate monitoring, step counting, and sleep tracking. Waterproof design.",
                        Price = 49.99,
                        Stock = 220,
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        CategoryId = Guid.NewGuid(),
                        Name = "CypressFlow Yoga Mat",
                        Description = "A non-slip yoga mat with extra cushioning for comfort. Perfect for yoga and pilates.",
                        Price = 29.99,
                        Stock = 500,
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        CategoryId = Guid.NewGuid(),
                        Name = "SpruceSky Drone",
                        Description = "A high-performance drone with HD camera and long battery life. Ideal for aerial photography.",
                        Price = 349.99,
                        Stock = 60,
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        CategoryId = Guid.NewGuid(),
                        Name = "JuniperPure Water Bottle",
                        Description = "An insulated water bottle that keeps drinks hot or cold for hours. Made from stainless steel.",
                        Price = 24.99,
                        Stock = 400,
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        CategoryId = Guid.NewGuid(),
                        Name = "MapleFlex Smartphone Case",
                        Description = "A durable and flexible smartphone case that provides excellent protection. Compatible with most models.",
                        Price = 19.99,
                        Stock = 350,
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        CategoryId = Guid.NewGuid(),
                        Name = "ElmGlow Table Lamp",
                        Description = "A contemporary table lamp with touch control and adjustable brightness. Perfect for any room.",
                        Price = 34.99,
                        Stock = 140,
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        CategoryId = Guid.NewGuid(),
                        Name = "PineEdge Kitchen Knife Set",
                        Description = "A professional kitchen knife set with high-carbon stainless steel blades. Includes 6 knives and ablock.",
                        Price = 89.99,
                        Stock = 85,
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        CategoryId = Guid.NewGuid(),
                        Name = "BirchSound Wireless Earbuds",
                        Description = "High-quality wireless earbuds with noise cancellation and long battery life. Comes with a chargingcase.",
                        Price = 79.99,
                        Stock = 300,
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        CategoryId = Guid.NewGuid(),
                        Name = "OakPure Coffee Maker",
                        Description = "A programmable coffee maker with a built-in grinder and timer. Makes up to 12 cups of coffee.",
                        Price = 129.99,
                        Stock = 90,
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        CategoryId = Guid.NewGuid(),
                        Name = "WillowLite Camping Tent",
                        Description = "A lightweight and durable camping tent that accommodates up to 4 people. Easy to set up.",
                        Price = 199.99,
                        Stock = 70,
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        CategoryId = Guid.NewGuid(),
                        Name = "AspenCool Mini Fridge",
                        Description = "A compact mini fridge with adjustable temperature settings. Perfect for dorm rooms and offices.",
                        Price = 149.99,
                        Stock = 120,
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        CategoryId = Guid.NewGuid(),
                        Name = "RedwoodMax Power Bank",
                        Description = "A high-capacity power bank with fast charging technology. Compatible with all USB devices.",
                        Price = 39.99,
                        Stock = 250,
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    }
                );
            }
        }
    }
}