using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_15 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CategoryName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    Address = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    Status = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Stock = table.Column<double>(type: "double precision", nullable: false),
                    Price = table.Column<double>(type: "double precision", nullable: false),
                    Description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    ImageUrl = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Surname = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    Password = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    Role = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "CreatedDate", "Description", "Status", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { new Guid("0becf285-0496-4a96-a173-d97b73957213"), "4444 Aspen Court, Meadowbrook, OR 97001", new DateTime(2024, 8, 28, 12, 33, 31, 928, DateTimeKind.Utc).AddTicks(3490), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 8, 28, 12, 33, 31, 928, DateTimeKind.Utc).AddTicks(3490), new Guid("b985d043-5d61-485f-8763-ecd30713d002") },
                    { new Guid("26f89e1e-4c0f-4ba5-a695-1829fe27620f"), "10101 Juniper Avenue, Blue Ridge, NC 27501", new DateTime(2024, 8, 28, 12, 33, 31, 928, DateTimeKind.Utc).AddTicks(3470), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 8, 28, 12, 33, 31, 928, DateTimeKind.Utc).AddTicks(3470), new Guid("e1de6c9f-2eac-4ccc-b601-aae0722f85cb") },
                    { new Guid("3e037c33-0ba0-447f-80f3-bed894699f27"), "456 Elm Avenue, Oakville, CA 94022", new DateTime(2024, 8, 28, 12, 33, 31, 928, DateTimeKind.Utc).AddTicks(3470), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 8, 28, 12, 33, 31, 928, DateTimeKind.Utc).AddTicks(3470), new Guid("fef8af3d-ba8f-4233-bb5c-8eddfe08ecbe") },
                    { new Guid("817d7e18-39ab-476f-a2c9-f7638542c80a"), "8888 Cypress Circle, Riverview, MI 48201", new DateTime(2024, 8, 28, 12, 33, 31, 928, DateTimeKind.Utc).AddTicks(3520), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 8, 28, 12, 33, 31, 928, DateTimeKind.Utc).AddTicks(3520), new Guid("06eeb5a6-bac3-4313-b4fe-d3c628d4737d") },
                    { new Guid("88e2a969-56e1-4211-a4aa-9aab01a9ff4c"), "789 Pine Lane, Rivertown, TX 75001", new DateTime(2024, 8, 28, 12, 33, 31, 928, DateTimeKind.Utc).AddTicks(3490), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 8, 28, 12, 33, 31, 928, DateTimeKind.Utc).AddTicks(3490), new Guid("a018b41f-8d52-4418-8cc5-73e15ef60924") },
                    { new Guid("9ee854c6-05f6-443a-add0-c5b8c61092c1"), "9999 Spruce Place, Highland, UT 84003", new DateTime(2024, 8, 28, 12, 33, 31, 928, DateTimeKind.Utc).AddTicks(3480), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 8, 28, 12, 33, 31, 928, DateTimeKind.Utc).AddTicks(3480), new Guid("058a981b-1b7c-407e-b2f9-ef23926c94b8") },
                    { new Guid("ae754905-958e-47c5-b8d4-e23b0c59d96f"), "5555 Redwood Street, Greenfield, AZ 85001", new DateTime(2024, 8, 28, 12, 33, 31, 928, DateTimeKind.Utc).AddTicks(3500), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 8, 28, 12, 33, 31, 928, DateTimeKind.Utc).AddTicks(3500), new Guid("f836461b-9e6d-4541-b020-2070115a60e5") },
                    { new Guid("b8d965dd-681f-4424-82ea-e5da389ed7ae"), "7777 Poplar Path, Brookhaven, GA 30301", new DateTime(2024, 8, 28, 12, 33, 31, 928, DateTimeKind.Utc).AddTicks(3510), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 8, 28, 12, 33, 31, 928, DateTimeKind.Utc).AddTicks(3510), new Guid("1427dd02-068c-4deb-97d3-dbfd2c6a4205") },
                    { new Guid("d67081c1-c39f-4465-85b1-219aebb2a8ae"), "1010 Birch Road, Forestville, WA 98001", new DateTime(2024, 8, 28, 12, 33, 31, 928, DateTimeKind.Utc).AddTicks(3510), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 8, 28, 12, 33, 31, 928, DateTimeKind.Utc).AddTicks(3510), new Guid("1e6a2ee0-1ded-4e33-893f-3c6077a1c24a") },
                    { new Guid("fa12f9a1-bc64-482b-b8b9-13dc6eaa5399"), "2222 Oak Drive, Hillcrest, NY 10001", new DateTime(2024, 8, 28, 12, 33, 31, 928, DateTimeKind.Utc).AddTicks(3460), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 8, 28, 12, 33, 31, 928, DateTimeKind.Utc).AddTicks(3460), new Guid("b4058b15-7ccc-4b8e-80ae-4157eedd42b0") }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "ImageUrl", "Name", "Price", "Stock", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("03d0acd7-2933-4f4b-be82-b1997ada2d50"), new Guid("2f6657f9-61e8-4088-8da7-c3f8fa33b4d1"), new DateTime(2024, 8, 28, 12, 33, 31, 928, DateTimeKind.Utc).AddTicks(3650), "A lightweight and durable camping tent that accommodates up to 4 people. Easy to set up.", " ", "WillowLite Camping Tent", 199.99000000000001, 70.0, new DateTime(2024, 8, 28, 12, 33, 31, 928, DateTimeKind.Utc).AddTicks(3650) },
                    { new Guid("08a2c45c-fd03-43b1-ac59-f708717b50d3"), new Guid("6a6ad2ea-589b-445c-afc9-8949433b3944"), new DateTime(2024, 8, 28, 12, 33, 31, 928, DateTimeKind.Utc).AddTicks(3660), "A compact mini fridge with adjustable temperature settings. Perfect for dorm rooms and offices.", " ", "AspenCool Mini Fridge", 149.99000000000001, 120.0, new DateTime(2024, 8, 28, 12, 33, 31, 928, DateTimeKind.Utc).AddTicks(3660) },
                    { new Guid("123f32e7-1546-406e-88cd-bdff6a1e4440"), new Guid("94175c28-676e-46cc-87d1-db6641f7985b"), new DateTime(2024, 8, 28, 12, 33, 31, 928, DateTimeKind.Utc).AddTicks(3560), "Lightweight and comfortable running shoes with breathable mesh and cushioned sole.", " ", "OakHill Running Shoes", 89.989999999999995, 300.0, new DateTime(2024, 8, 28, 12, 33, 31, 928, DateTimeKind.Utc).AddTicks(3560) },
                    { new Guid("34500b8a-5f3b-4840-8410-92b389ed3d9b"), new Guid("09afce93-ca6a-4ce6-bf4b-3136053ee675"), new DateTime(2024, 8, 28, 12, 33, 31, 928, DateTimeKind.Utc).AddTicks(3620), "A durable and flexible smartphone case that provides excellent protection. Compatible with most models.", " ", "MapleFlex Smartphone Case", 19.989999999999998, 350.0, new DateTime(2024, 8, 28, 12, 33, 31, 928, DateTimeKind.Utc).AddTicks(3620) },
                    { new Guid("38db490a-a62d-4891-82e7-42838b0eece5"), new Guid("99eef1fb-8c11-45cc-9035-502fc184c2a7"), new DateTime(2024, 8, 28, 12, 33, 31, 928, DateTimeKind.Utc).AddTicks(3630), "A contemporary table lamp with touch control and adjustable brightness. Perfect for any room.", " ", "ElmGlow Table Lamp", 34.990000000000002, 140.0, new DateTime(2024, 8, 28, 12, 33, 31, 928, DateTimeKind.Utc).AddTicks(3630) },
                    { new Guid("3f8e199e-0baa-4fde-b319-4a06dc816bfe"), new Guid("50b208f3-f3f9-46dc-bc5f-369ee6a11cab"), new DateTime(2024, 8, 28, 12, 33, 31, 928, DateTimeKind.Utc).AddTicks(3640), "A programmable coffee maker with a built-in grinder and timer. Makes up to 12 cups of coffee.", " ", "OakPure Coffee Maker", 129.99000000000001, 90.0, new DateTime(2024, 8, 28, 12, 33, 31, 928, DateTimeKind.Utc).AddTicks(3640) },
                    { new Guid("57d0898c-51d9-42cc-a951-89391a0b547b"), new Guid("bc291680-61cb-4986-8942-c7b7be73f2f0"), new DateTime(2024, 8, 28, 12, 33, 31, 928, DateTimeKind.Utc).AddTicks(3630), "A professional kitchen knife set with high-carbon stainless steel blades. Includes 6 knives and ablock.", " ", "PineEdge Kitchen Knife Set", 89.989999999999995, 85.0, new DateTime(2024, 8, 28, 12, 33, 31, 928, DateTimeKind.Utc).AddTicks(3630) },
                    { new Guid("64698262-0473-4a84-9544-d95e5f000b4c"), new Guid("e5c01897-3156-48a4-8738-52886f754f6a"), new DateTime(2024, 8, 28, 12, 33, 31, 928, DateTimeKind.Utc).AddTicks(3580), "A powerful gaming laptop with high-end graphics and fast processing speed. Ideal for gamers.", " ", "RedwoodX Gaming Laptop", 1299.99, 30.0, new DateTime(2024, 8, 28, 12, 33, 31, 928, DateTimeKind.Utc).AddTicks(3580) },
                    { new Guid("6a93e5e5-ce27-41b5-9afe-fa3312ca7c74"), new Guid("95073484-fba3-43d8-8231-c428a47aef53"), new DateTime(2024, 8, 28, 12, 33, 31, 928, DateTimeKind.Utc).AddTicks(3570), "A stylish LED lamp with adjustable brightness and color temperature. Ideal for reading and working.", " ", "AspenGlow LED Lamp", 39.990000000000002, 180.0, new DateTime(2024, 8, 28, 12, 33, 31, 928, DateTimeKind.Utc).AddTicks(3570) },
                    { new Guid("76b92cd9-a59f-413e-8247-e1bc74016a28"), new Guid("9ef788ca-6934-43c6-b29f-43b90c52b45c"), new DateTime(2024, 8, 28, 12, 33, 31, 928, DateTimeKind.Utc).AddTicks(3550), "An ergonomic office chair with adjustable height and lumbar support. Ideal for long hours of work.", " ", "BirchCraft Office Chair", 149.99000000000001, 150.0, new DateTime(2024, 8, 28, 12, 33, 31, 928, DateTimeKind.Utc).AddTicks(3550) },
                    { new Guid("861144da-e256-4ca6-8f17-b5c572beb938"), new Guid("805cb91a-d76e-4cb0-9f4d-4ac23901ac5b"), new DateTime(2024, 8, 28, 12, 33, 31, 928, DateTimeKind.Utc).AddTicks(3580), "A smart home security camera with night vision and motion detection. Connects to your smartphone.", " ", "FirNest Home Security Camera", 99.989999999999995, 100.0, new DateTime(2024, 8, 28, 12, 33, 31, 928, DateTimeKind.Utc).AddTicks(3580) },
                    { new Guid("8e5bfaf6-1867-4b6f-b2a3-03a2c199efda"), new Guid("0687ca11-a914-458c-bfa6-992622f73e31"), new DateTime(2024, 8, 28, 12, 33, 31, 928, DateTimeKind.Utc).AddTicks(3560), "A portable Bluetooth speaker with high-quality sound and long battery life. Perfectforoutdooractivities.", " ", "WillowWave Bluetooth Speaker", 59.990000000000002, 250.0, new DateTime(2024, 8, 28, 12, 33, 31, 928, DateTimeKind.Utc).AddTicks(3560) },
                    { new Guid("99561756-e4e0-4d90-bb7f-2ebbf05b70b2"), new Guid("8800eb37-0422-4731-9c79-86d425d15dc4"), new DateTime(2024, 8, 28, 12, 33, 31, 928, DateTimeKind.Utc).AddTicks(3590), "A fitness tracker with heart rate monitoring, step counting, and sleep tracking. Waterproof design.", " ", "PoplarPulse Fitness Tracker", 49.990000000000002, 220.0, new DateTime(2024, 8, 28, 12, 33, 31, 928, DateTimeKind.Utc).AddTicks(3590) },
                    { new Guid("9e0bc21f-e81e-4540-b940-164deecb7521"), new Guid("2a074377-54c9-48ab-a1fc-4b722cec3f8d"), new DateTime(2024, 8, 28, 12, 33, 31, 928, DateTimeKind.Utc).AddTicks(3600), "A high-performance drone with HD camera and long battery life. Ideal for aerial photography.", " ", "SpruceSky Drone", 349.99000000000001, 60.0, new DateTime(2024, 8, 28, 12, 33, 31, 928, DateTimeKind.Utc).AddTicks(3600) },
                    { new Guid("a15821de-5a1d-42ee-9bf6-2736ebd5b07e"), new Guid("6875434d-f6ff-460f-a96a-0cfd2946d55e"), new DateTime(2024, 8, 28, 12, 33, 31, 928, DateTimeKind.Utc).AddTicks(3600), "A non-slip yoga mat with extra cushioning for comfort. Perfect for yoga and pilates.", " ", "CypressFlow Yoga Mat", 29.989999999999998, 500.0, new DateTime(2024, 8, 28, 12, 33, 31, 928, DateTimeKind.Utc).AddTicks(3600) },
                    { new Guid("aaf70b7d-43e4-4c44-b3a5-d8062d8d1ca0"), new Guid("522bbdf7-8fac-402b-945f-b6e6bc85519d"), new DateTime(2024, 8, 28, 12, 33, 31, 928, DateTimeKind.Utc).AddTicks(3610), "An insulated water bottle that keeps drinks hot or cold for hours. Made from stainless steel.", " ", "JuniperPure Water Bottle", 24.989999999999998, 400.0, new DateTime(2024, 8, 28, 12, 33, 31, 928, DateTimeKind.Utc).AddTicks(3610) },
                    { new Guid("d9f9bcb1-eea4-4897-92e9-9627cde5a6d0"), new Guid("3a1d31ed-57e9-45df-aefe-0d124a5820b5"), new DateTime(2024, 8, 28, 12, 33, 31, 928, DateTimeKind.Utc).AddTicks(3660), "A high-capacity power bank with fast charging technology. Compatible with all USB devices.", " ", "RedwoodMax Power Bank", 39.990000000000002, 250.0, new DateTime(2024, 8, 28, 12, 33, 31, 928, DateTimeKind.Utc).AddTicks(3660) },
                    { new Guid("f9028139-2025-4206-8761-092e4bcfe568"), new Guid("41f42a51-edce-4fa9-ad5d-f5d93a070977"), new DateTime(2024, 8, 28, 12, 33, 31, 928, DateTimeKind.Utc).AddTicks(3640), "High-quality wireless earbuds with noise cancellation and long battery life. Comes with a chargingcase.", " ", "BirchSound Wireless Earbuds", 79.989999999999995, 300.0, new DateTime(2024, 8, 28, 12, 33, 31, 928, DateTimeKind.Utc).AddTicks(3640) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "Email", "Name", "Password", "Role", "Surname", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("020a383b-7d70-4685-bd94-6e0dcd4c0db0"), new DateTime(2024, 8, 28, 12, 33, 31, 921, DateTimeKind.Utc).AddTicks(9560), "example13@mail.com", "Barış Onur", "gZaC/dwS3JNg4BO7bZHZ6g==.lfk0eWYC9vVScl5lsh9m2t9zwbi0M+CBYImbO4lqPLE=", false, "Aydın", new DateTime(2024, 8, 28, 12, 33, 31, 921, DateTimeKind.Utc).AddTicks(9560) },
                    { new Guid("06e7a3fe-3184-443a-91c5-f0afe47202ee"), new DateTime(2024, 8, 28, 12, 33, 31, 876, DateTimeKind.Utc).AddTicks(7080), "example6@mail.com", "Ahmet Mümtaz", "EB4D9AGXvh/ZwyM6YR2GIw==.7NB4fJyXjePft2KGHcozPQkhH5TrYE+6t3q3aAUwGQQ=", false, "Taylan", new DateTime(2024, 8, 28, 12, 33, 31, 876, DateTimeKind.Utc).AddTicks(7080) },
                    { new Guid("1931a463-5801-4ccb-9527-54f621d5ee39"), new DateTime(2024, 8, 28, 12, 33, 31, 915, DateTimeKind.Utc).AddTicks(6120), "example12@mail.com", "Barkın", "4Ef0flAL3YhVcbkFcNocng==.1snfbObffAeO3Xb+EjcVLCl2uG6GxY3T3Y/qXPA/oRQ=", false, "Özkaplan", new DateTime(2024, 8, 28, 12, 33, 31, 915, DateTimeKind.Utc).AddTicks(6120) },
                    { new Guid("2b8b87a8-2ae2-496a-8720-d72ee40e32ac"), new DateTime(2024, 8, 28, 12, 33, 31, 889, DateTimeKind.Utc).AddTicks(5110), "example8@mail.com", "Şahan", "SE/2dWbXnOB3CBKyQTn3WA==.hbBlK5Ltp3kfn5f5lfRfIpiW0CUt69LumCnI/zayffE=", false, "Gökbakar", new DateTime(2024, 8, 28, 12, 33, 31, 889, DateTimeKind.Utc).AddTicks(5110) },
                    { new Guid("2e5360c3-2ade-4fd8-9bdf-62461914f598"), new DateTime(2024, 8, 28, 12, 33, 31, 833, DateTimeKind.Utc).AddTicks(4490), "example1@mail.com", "Berke", "k/IjKMOsqgkhOkR7hIfBpg==.1bT858Pkzd2mHeQikdORF3RjYoK3Gwndu5ln1Spw8zE=", true, "Öztürk", new DateTime(2024, 8, 28, 12, 33, 31, 833, DateTimeKind.Utc).AddTicks(4490) },
                    { new Guid("3d11d32e-6837-4c3d-9ddd-93c00a92ea22"), new DateTime(2024, 8, 28, 12, 33, 31, 850, DateTimeKind.Utc).AddTicks(7000), "example3@mail.com", "Ervin", "cfYOrBNMlEhxRhUf/bVHkg==.9IxQ4Fd78V93poOmNAEmT4BmLDaG/iq0YMVAhISc1xo=", false, "Parlak", new DateTime(2024, 8, 28, 12, 33, 31, 850, DateTimeKind.Utc).AddTicks(7000) },
                    { new Guid("3f7fd603-ae9d-41b4-80cc-f71f4599695c"), new DateTime(2024, 8, 28, 12, 33, 31, 860, DateTimeKind.Utc).AddTicks(4020), "example4@mail.com", "Gamze Naz", "UcGZCHCflmcVyQF9CJ/MwQ==.x/9e9rIwEGjgbbFAtSoI4K3NTQrBncwcAFzjx273vdM=", false, "Yıldırım", new DateTime(2024, 8, 28, 12, 33, 31, 860, DateTimeKind.Utc).AddTicks(4020) },
                    { new Guid("5cc55018-3598-4034-8cab-5a535af8c59c"), new DateTime(2024, 8, 28, 12, 33, 31, 928, DateTimeKind.Utc).AddTicks(3050), "example14@mail.com", "Deniz", "pjjfw4/MAR8gWbM/ajZJyQ==.WjphaIZznXYRCGehBiiHnjqfN+zpmiIO5zOH6krvpIo=", false, "Zarshat", new DateTime(2024, 8, 28, 12, 33, 31, 928, DateTimeKind.Utc).AddTicks(3050) },
                    { new Guid("7400829f-7021-46dd-a464-6079f015807f"), new DateTime(2024, 8, 28, 12, 33, 31, 895, DateTimeKind.Utc).AddTicks(8670), "example9@mail.com", "Mahsun", "0vtcVQT7IXPUqJU+XF4v1Q==.YIQCXOkyceb95XmtMwqRm2S8WNpJUstvfZqV6zF6Ne0=", false, "Kırmızıgül", new DateTime(2024, 8, 28, 12, 33, 31, 895, DateTimeKind.Utc).AddTicks(8670) },
                    { new Guid("7eb568ef-e3a0-43d1-8165-61981b3cbe9b"), new DateTime(2024, 8, 28, 12, 33, 31, 883, DateTimeKind.Utc).AddTicks(1160), "example7@mail.com", "Cem", "UUQAlWt64XYe/e1BTlj/6g==.a8bgNX/+goGhTVSkF+Byz947XvEwaZQcZtWTNHt8b08=", false, "Yılmaz", new DateTime(2024, 8, 28, 12, 33, 31, 883, DateTimeKind.Utc).AddTicks(1160) },
                    { new Guid("91eab9f7-fe42-4682-aec2-c5779e996a29"), new DateTime(2024, 8, 28, 12, 33, 31, 841, DateTimeKind.Utc).AddTicks(9110), "example2@mail.com", "Doğa Su", "Uc0UcZUaPAVOwamWMjkWHg==.CBhO2zMeHA4dB+WBRw4RSZA4II5dmhKccakVEcGKyY0=", false, "Türkileri", new DateTime(2024, 8, 28, 12, 33, 31, 841, DateTimeKind.Utc).AddTicks(9110) },
                    { new Guid("a94b43c4-0fc8-4665-a86f-cc5cd1e7f505"), new DateTime(2024, 8, 28, 12, 33, 31, 908, DateTimeKind.Utc).AddTicks(6320), "example11@mail.com", "Ozan", "0g5Y960fSy9laczctg82fQ==.SdcA+3/OIGDgCXSVUMfxHt/YDkuyuY4bzU0GYOSltOY=", false, "İmamhatipoğlu", new DateTime(2024, 8, 28, 12, 33, 31, 908, DateTimeKind.Utc).AddTicks(6320) },
                    { new Guid("e2967197-930b-4f44-b90e-7f8b6ff6a75d"), new DateTime(2024, 8, 28, 12, 33, 31, 902, DateTimeKind.Utc).AddTicks(2440), "example10@mail.com", "Erkin", "PqGbDZ0sTYD2NWLLq+omEw==.o+BidiT1c+QO7Rx4R44Kk6rOTrDyexB6k8jQwxrehSs=", false, "Karaçay", new DateTime(2024, 8, 28, 12, 33, 31, 902, DateTimeKind.Utc).AddTicks(2440) },
                    { new Guid("fb0a9f34-fefe-4a88-a292-53b92a7bdb93"), new DateTime(2024, 8, 28, 12, 33, 31, 869, DateTimeKind.Utc).AddTicks(8480), "example5@mail.com", "Atakan", "ke37r/fH3m4LnVgVPF7UJQ==.+d3rxVCqn+kDsM8JAzOKf7RpaYzB5Rmg6Lq0WrbnHRI=", false, "Yıldırım", new DateTime(2024, 8, 28, 12, 33, 31, 869, DateTimeKind.Utc).AddTicks(8480) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
