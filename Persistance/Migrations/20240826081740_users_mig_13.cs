using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistance.Migrations
{
    /// <inheritdoc />
    public partial class users_mig_13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("1167cb57-3733-4617-91ba-f4fbf4b7f4ff"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("5cce196d-483e-482d-a0af-6fc77414f2b7"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("65388f87-6da2-4e87-b051-27c79eef6952"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("6bbbcbcf-b07a-4ff2-a1a8-eebceef132a9"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("72603581-ce02-47cd-b49d-cf880999e49f"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("7ef1842d-c735-4de7-a917-decd0d3cf90f"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("9ddaa299-ca19-407b-b61c-c6a6880ccc0f"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("c8b16188-583d-471f-b8ed-7976fab8f70d"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ce2532db-6973-4561-8584-86398c6b2be9"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("cf1834cb-76bc-464c-b881-a5379c218e03"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1a01a99a-b6dc-4ad7-9f11-61d6d12a7909"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("39048274-1b85-40c8-88c8-61267ef244ae"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4408d508-a7ed-4545-99f2-648f31a94b15"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4956083a-28c9-454e-a95c-c38eb4d3ad33"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("58011a47-b8a6-47cd-abb0-014755326b2e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6b99a619-e692-4b77-91c6-dc9aa69389e6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7af4b8d3-9c92-4077-acaf-6135b2183203"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("823c6a14-1e90-479a-9eef-e351307a606d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("98e9eafa-7d7d-4795-9318-8047aa68f4cc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9cbb9f00-ab13-4c56-94a5-96057560172f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a7aa39fa-cfc6-4f71-be18-7d400d977d39"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b44d2758-a173-4bc0-8a68-3ac0053d72ad"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c6636e32-ee1b-4326-81b9-5d6e2ca65ee3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d280b94d-ec89-43c9-a553-fea33dd69285"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("de84e562-7e86-4ee4-8cf0-5933d1aed2aa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e3dd8313-e6b5-4bbc-87d1-cbe35a719e70"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f1e75dd1-0eec-4633-a0ee-4f28f39cc476"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f72946a5-52aa-4424-8dbe-9d3aa3e5ad81"));

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Orders",
                newName: "UserId");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
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
                    { new Guid("0d365429-e505-4433-908f-d2e4ffd0b8f2"), "789 Pine Lane, Rivertown, TX 75001", new DateTime(2024, 8, 26, 8, 17, 40, 832, DateTimeKind.Utc).AddTicks(5790), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 8, 26, 8, 17, 40, 832, DateTimeKind.Utc).AddTicks(5790), new Guid("a196f7b1-42cf-4088-9124-3fd2d65a6d65") },
                    { new Guid("25fc7ef0-7c6a-432d-9a56-074b99d4d622"), "10101 Juniper Avenue, Blue Ridge, NC 27501", new DateTime(2024, 8, 26, 8, 17, 40, 832, DateTimeKind.Utc).AddTicks(5770), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 8, 26, 8, 17, 40, 832, DateTimeKind.Utc).AddTicks(5770), new Guid("02df638f-c14f-4115-8301-e83165d59cc8") },
                    { new Guid("2d83f74b-036b-4ff2-a265-d73ef064ee51"), "9999 Spruce Place, Highland, UT 84003", new DateTime(2024, 8, 26, 8, 17, 40, 832, DateTimeKind.Utc).AddTicks(5780), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 8, 26, 8, 17, 40, 832, DateTimeKind.Utc).AddTicks(5780), new Guid("c6c2b197-9a20-4039-9e2d-2e2d58f8e2b8") },
                    { new Guid("4835cd2f-d076-41e3-8d85-99d07eb397ce"), "4444 Aspen Court, Meadowbrook, OR 97001", new DateTime(2024, 8, 26, 8, 17, 40, 832, DateTimeKind.Utc).AddTicks(5780), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 8, 26, 8, 17, 40, 832, DateTimeKind.Utc).AddTicks(5780), new Guid("86364497-0f07-405f-89e2-88bc3262d6cb") },
                    { new Guid("4dc08078-f24d-4ec7-b467-911ceaa6ef17"), "8888 Cypress Circle, Riverview, MI 48201", new DateTime(2024, 8, 26, 8, 17, 40, 832, DateTimeKind.Utc).AddTicks(5810), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 8, 26, 8, 17, 40, 832, DateTimeKind.Utc).AddTicks(5810), new Guid("9a5d6e93-8027-4732-b047-b4a3c64e4f14") },
                    { new Guid("561b2425-b07e-44d1-bf09-f0c3f3a7c883"), "5555 Redwood Street, Greenfield, AZ 85001", new DateTime(2024, 8, 26, 8, 17, 40, 832, DateTimeKind.Utc).AddTicks(5800), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 8, 26, 8, 17, 40, 832, DateTimeKind.Utc).AddTicks(5800), new Guid("313a7566-1785-47a8-a242-20de138348eb") },
                    { new Guid("5acdf448-7e8b-4b72-958e-744fa70d6252"), "456 Elm Avenue, Oakville, CA 94022", new DateTime(2024, 8, 26, 8, 17, 40, 832, DateTimeKind.Utc).AddTicks(5760), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 8, 26, 8, 17, 40, 832, DateTimeKind.Utc).AddTicks(5760), new Guid("256c52b3-8f88-4b8d-90ab-eb6a2004fa31") },
                    { new Guid("6754713d-5277-4775-9e32-75462ded4e40"), "7777 Poplar Path, Brookhaven, GA 30301", new DateTime(2024, 8, 26, 8, 17, 40, 832, DateTimeKind.Utc).AddTicks(5800), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 8, 26, 8, 17, 40, 832, DateTimeKind.Utc).AddTicks(5800), new Guid("a27d1c27-2c91-44e0-84ff-69f51ee70b73") },
                    { new Guid("6e33fd07-92c3-446f-a793-08c478ebdfad"), "1010 Birch Road, Forestville, WA 98001", new DateTime(2024, 8, 26, 8, 17, 40, 832, DateTimeKind.Utc).AddTicks(5810), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 8, 26, 8, 17, 40, 832, DateTimeKind.Utc).AddTicks(5810), new Guid("c18b7dc9-edb3-4ced-9e58-c050f72602b1") },
                    { new Guid("9c90e391-d052-418f-a12f-8db5091fb9be"), "2222 Oak Drive, Hillcrest, NY 10001", new DateTime(2024, 8, 26, 8, 17, 40, 832, DateTimeKind.Utc).AddTicks(5760), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 8, 26, 8, 17, 40, 832, DateTimeKind.Utc).AddTicks(5760), new Guid("3b443e40-3601-4f39-aeee-727bb3c90317") }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "ImageUrl", "Name", "Price", "Stock", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0ad09f4d-f857-4ed8-b7a1-bb2f445bc3ea"), new Guid("f223253c-cf58-411e-a8f7-96181622f484"), new DateTime(2024, 8, 26, 8, 17, 40, 832, DateTimeKind.Utc).AddTicks(5860), "A portable Bluetooth speaker with high-quality sound and long battery life. Perfectforoutdooractivities.", " ", "WillowWave Bluetooth Speaker", 59.990000000000002, 250.0, new DateTime(2024, 8, 26, 8, 17, 40, 832, DateTimeKind.Utc).AddTicks(5860) },
                    { new Guid("10ccdcd2-2b86-4cca-9213-f1307483b730"), new Guid("5cc2ecfc-6c41-4f89-b7de-ed9377ac553e"), new DateTime(2024, 8, 26, 8, 17, 40, 832, DateTimeKind.Utc).AddTicks(5920), "A contemporary table lamp with touch control and adjustable brightness. Perfect for any room.", " ", "ElmGlow Table Lamp", 34.990000000000002, 140.0, new DateTime(2024, 8, 26, 8, 17, 40, 832, DateTimeKind.Utc).AddTicks(5920) },
                    { new Guid("33642377-872c-47f4-b26e-8d074c9b357e"), new Guid("aef668c6-6392-4b04-8302-2915c7cf652f"), new DateTime(2024, 8, 26, 8, 17, 40, 832, DateTimeKind.Utc).AddTicks(5980), "A programmable coffee maker with a built-in grinder and timer. Makes up to 12 cups of coffee.", " ", "OakPure Coffee Maker", 129.99000000000001, 90.0, new DateTime(2024, 8, 26, 8, 17, 40, 832, DateTimeKind.Utc).AddTicks(5980) },
                    { new Guid("62513fdd-4ac0-4362-8396-ae7ff79c98b4"), new Guid("279321e0-c863-43f0-9738-67117d37bbcd"), new DateTime(2024, 8, 26, 8, 17, 40, 832, DateTimeKind.Utc).AddTicks(5870), "A powerful gaming laptop with high-end graphics and fast processing speed. Ideal for gamers.", " ", "RedwoodX Gaming Laptop", 1299.99, 30.0, new DateTime(2024, 8, 26, 8, 17, 40, 832, DateTimeKind.Utc).AddTicks(5870) },
                    { new Guid("633837ae-cccd-4d22-a7c6-6a79add972e9"), new Guid("0d8f78f9-8583-474e-bb1d-16a410a737b0"), new DateTime(2024, 8, 26, 8, 17, 40, 832, DateTimeKind.Utc).AddTicks(5840), "An ergonomic office chair with adjustable height and lumbar support. Ideal for long hours of work.", " ", "BirchCraft Office Chair", 149.99000000000001, 150.0, new DateTime(2024, 8, 26, 8, 17, 40, 832, DateTimeKind.Utc).AddTicks(5840) },
                    { new Guid("8a7b240e-02fd-4b07-bf2f-fbcb69a7cf17"), new Guid("5c3a0201-5e87-4b43-8313-dd67824ca7eb"), new DateTime(2024, 8, 26, 8, 17, 40, 832, DateTimeKind.Utc).AddTicks(5970), "High-quality wireless earbuds with noise cancellation and long battery life. Comes with a chargingcase.", " ", "BirchSound Wireless Earbuds", 79.989999999999995, 300.0, new DateTime(2024, 8, 26, 8, 17, 40, 832, DateTimeKind.Utc).AddTicks(5970) },
                    { new Guid("8cab617b-2cf2-472f-a094-364d12f289f3"), new Guid("08b5ecd2-03a9-4d16-aac8-1ec648cff218"), new DateTime(2024, 8, 26, 8, 17, 40, 832, DateTimeKind.Utc).AddTicks(5900), "A high-performance drone with HD camera and long battery life. Ideal for aerial photography.", " ", "SpruceSky Drone", 349.99000000000001, 60.0, new DateTime(2024, 8, 26, 8, 17, 40, 832, DateTimeKind.Utc).AddTicks(5900) },
                    { new Guid("91c0f984-113f-4b44-a8a0-42b111941e45"), new Guid("068cd54c-4b5d-49c0-86c1-57626fba70f4"), new DateTime(2024, 8, 26, 8, 17, 40, 832, DateTimeKind.Utc).AddTicks(5930), "A professional kitchen knife set with high-carbon stainless steel blades. Includes 6 knives and ablock.", " ", "PineEdge Kitchen Knife Set", 89.989999999999995, 85.0, new DateTime(2024, 8, 26, 8, 17, 40, 832, DateTimeKind.Utc).AddTicks(5930) },
                    { new Guid("91eafcbe-b8fd-4561-8c64-d19c8654518f"), new Guid("7e8f03c5-287b-4392-82d9-2456f75fc4d2"), new DateTime(2024, 8, 26, 8, 17, 40, 832, DateTimeKind.Utc).AddTicks(5910), "An insulated water bottle that keeps drinks hot or cold for hours. Made from stainless steel.", " ", "JuniperPure Water Bottle", 24.989999999999998, 400.0, new DateTime(2024, 8, 26, 8, 17, 40, 832, DateTimeKind.Utc).AddTicks(5910) },
                    { new Guid("97f3ee84-c5af-44b0-b9cc-cdb283491659"), new Guid("5a9e2180-5fa9-4a94-b32e-dfbcd883cbde"), new DateTime(2024, 8, 26, 8, 17, 40, 832, DateTimeKind.Utc).AddTicks(5990), "A compact mini fridge with adjustable temperature settings. Perfect for dorm rooms and offices.", " ", "AspenCool Mini Fridge", 149.99000000000001, 120.0, new DateTime(2024, 8, 26, 8, 17, 40, 832, DateTimeKind.Utc).AddTicks(5990) },
                    { new Guid("9a4134f8-190c-40fa-98ea-30cf6c88d29b"), new Guid("be98335c-0d68-4283-a3cc-6420fc37e23a"), new DateTime(2024, 8, 26, 8, 17, 40, 832, DateTimeKind.Utc).AddTicks(5850), "Lightweight and comfortable running shoes with breathable mesh and cushioned sole.", " ", "OakHill Running Shoes", 89.989999999999995, 300.0, new DateTime(2024, 8, 26, 8, 17, 40, 832, DateTimeKind.Utc).AddTicks(5850) },
                    { new Guid("b05ca891-91f7-4bd7-887e-b3d479d5afc0"), new Guid("b87b606c-6f14-446a-8576-44934d9f0f37"), new DateTime(2024, 8, 26, 8, 17, 40, 832, DateTimeKind.Utc).AddTicks(5920), "A durable and flexible smartphone case that provides excellent protection. Compatible with most models.", " ", "MapleFlex Smartphone Case", 19.989999999999998, 350.0, new DateTime(2024, 8, 26, 8, 17, 40, 832, DateTimeKind.Utc).AddTicks(5920) },
                    { new Guid("bf2b983d-988b-4710-87e1-f6110f7cc8d0"), new Guid("a211a972-d553-495a-8be8-d5f7aaa202de"), new DateTime(2024, 8, 26, 8, 17, 40, 832, DateTimeKind.Utc).AddTicks(5880), "A smart home security camera with night vision and motion detection. Connects to your smartphone.", " ", "FirNest Home Security Camera", 99.989999999999995, 100.0, new DateTime(2024, 8, 26, 8, 17, 40, 832, DateTimeKind.Utc).AddTicks(5880) },
                    { new Guid("c603995c-a79d-4c25-b3a5-fa182df1ee33"), new Guid("1b445253-9cf9-4866-8e08-65899d408d93"), new DateTime(2024, 8, 26, 8, 17, 40, 832, DateTimeKind.Utc).AddTicks(5880), "A fitness tracker with heart rate monitoring, step counting, and sleep tracking. Waterproof design.", " ", "PoplarPulse Fitness Tracker", 49.990000000000002, 220.0, new DateTime(2024, 8, 26, 8, 17, 40, 832, DateTimeKind.Utc).AddTicks(5880) },
                    { new Guid("c9520333-2d09-4cbf-b3ac-f3914d1cb459"), new Guid("2a1ae796-64ce-4c92-9084-fa831042a2d6"), new DateTime(2024, 8, 26, 8, 17, 40, 832, DateTimeKind.Utc).AddTicks(6000), "A high-capacity power bank with fast charging technology. Compatible with all USB devices.", " ", "RedwoodMax Power Bank", 39.990000000000002, 250.0, new DateTime(2024, 8, 26, 8, 17, 40, 832, DateTimeKind.Utc).AddTicks(6000) },
                    { new Guid("e9fef5eb-f52a-44f6-9d03-d42f83989069"), new Guid("87b942ca-ccf4-4449-873b-3653734c6f1d"), new DateTime(2024, 8, 26, 8, 17, 40, 832, DateTimeKind.Utc).AddTicks(5860), "A stylish LED lamp with adjustable brightness and color temperature. Ideal for reading and working.", " ", "AspenGlow LED Lamp", 39.990000000000002, 180.0, new DateTime(2024, 8, 26, 8, 17, 40, 832, DateTimeKind.Utc).AddTicks(5860) },
                    { new Guid("f5c7dbb1-99af-48ee-92ad-3b82edfdf0a8"), new Guid("b8e4ae18-d0ba-438a-a16a-45f4a06f06f9"), new DateTime(2024, 8, 26, 8, 17, 40, 832, DateTimeKind.Utc).AddTicks(5890), "A non-slip yoga mat with extra cushioning for comfort. Perfect for yoga and pilates.", " ", "CypressFlow Yoga Mat", 29.989999999999998, 500.0, new DateTime(2024, 8, 26, 8, 17, 40, 832, DateTimeKind.Utc).AddTicks(5890) },
                    { new Guid("fe13a957-6c14-4742-b8fb-8fc6b5ada57d"), new Guid("9e508cb2-b4a0-45af-ba77-1c5739d67105"), new DateTime(2024, 8, 26, 8, 17, 40, 832, DateTimeKind.Utc).AddTicks(5990), "A lightweight and durable camping tent that accommodates up to 4 people. Easy to set up.", " ", "WillowLite Camping Tent", 199.99000000000001, 70.0, new DateTime(2024, 8, 26, 8, 17, 40, 832, DateTimeKind.Utc).AddTicks(5990) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "Email", "Name", "Password", "Role", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("13c450ed-ca54-4508-af13-d7f5e4ee912b"), new DateTime(2024, 8, 26, 8, 17, 40, 746, DateTimeKind.Utc).AddTicks(3020), "example1@mail.com", "Berke Öztürk", "pgTuHaTuJ4uRrd1waSbt8A==.XGZ3aqAyrnSJzLNqA5nqfmdqGfb0m2l9FMzA4zIJnSY=", false, new DateTime(2024, 8, 26, 8, 17, 40, 746, DateTimeKind.Utc).AddTicks(3020) },
                    { new Guid("213e6b7d-d56b-4733-b252-6b0de05c8e81"), new DateTime(2024, 8, 26, 8, 17, 40, 812, DateTimeKind.Utc).AddTicks(5560), "example11@mail.com", "Ozan İmamhatipoğlu", "GWU4dXdo2JBloCfPF6LmHg==.nWhIrZWb2ggnTrRvwIiMkqQwCyyYzWEuo9eL12yGl9M=", false, new DateTime(2024, 8, 26, 8, 17, 40, 812, DateTimeKind.Utc).AddTicks(5560) },
                    { new Guid("214bea2d-3b3a-43b3-a9b5-e5fe87aa7591"), new DateTime(2024, 8, 26, 8, 17, 40, 773, DateTimeKind.Utc).AddTicks(8110), "example5@mail.com", "Atakan Yıldırım", "tVEz1rpgCbHDpuR3u4w+XQ==.bDxbpv43U+goP8lYYPXdynkdAP0G69sovWKhexjK5ko=", false, new DateTime(2024, 8, 26, 8, 17, 40, 773, DateTimeKind.Utc).AddTicks(8110) },
                    { new Guid("23ed5f61-d970-4dd5-adf9-82022549925f"), new DateTime(2024, 8, 26, 8, 17, 40, 832, DateTimeKind.Utc).AddTicks(5540), "example14@mail.com", "Deniz Zarshat", "nuHWFLNx5dX7wJYCT7VdHQ==.QyF8NeNlj4zQaqpBeTPO8TyCRSvm/hTEVGmgcSGawfI=", false, new DateTime(2024, 8, 26, 8, 17, 40, 832, DateTimeKind.Utc).AddTicks(5540) },
                    { new Guid("30c245f8-65fe-4c1f-a780-796b8a543431"), new DateTime(2024, 8, 26, 8, 17, 40, 786, DateTimeKind.Utc).AddTicks(7510), "example7@mail.com", "Cem Yılmaz", "pHEq94/F6FmNB/A55zkP2g==.SYjiB8iOCd25Ddkp5QC/SUXJaG3GirVVwKF1lxAn6sw=", false, new DateTime(2024, 8, 26, 8, 17, 40, 786, DateTimeKind.Utc).AddTicks(7510) },
                    { new Guid("45274ff9-98bf-444e-b741-5b42f5bb261b"), new DateTime(2024, 8, 26, 8, 17, 40, 826, DateTimeKind.Utc).AddTicks(350), "example13@mail.com", "Barış Onur Aydın", "y0wrjhPl465JWO7V7v3UBQ==.cEA+I0OhM9ntkgR7LVhh6qTkinbDDUOx4EKiTA1kRUw=", false, new DateTime(2024, 8, 26, 8, 17, 40, 826, DateTimeKind.Utc).AddTicks(350) },
                    { new Guid("4b83e3e9-aba0-480d-a316-b23206ef415c"), new DateTime(2024, 8, 26, 8, 17, 40, 759, DateTimeKind.Utc).AddTicks(2220), "example3@mail.com", "Ervin Parlak", "fDWekEQWkIeGafaG6LGgyA==.9GUaGQ9YPYNVxem2VP3I2zmLpSpeuujKKP/UgXE6qQY=", false, new DateTime(2024, 8, 26, 8, 17, 40, 759, DateTimeKind.Utc).AddTicks(2220) },
                    { new Guid("513b1b98-7ff9-4932-b407-d5087e282511"), new DateTime(2024, 8, 26, 8, 17, 40, 780, DateTimeKind.Utc).AddTicks(2940), "example6@mail.com", "Ahmet Mümtaz Taylan", "6h7HWLYaGGmmmexMeqn0lQ==.OSrq3XZRXMhsZtun7WdsnVWDDCtIvwseav0KEeJBWsw=", false, new DateTime(2024, 8, 26, 8, 17, 40, 780, DateTimeKind.Utc).AddTicks(2940) },
                    { new Guid("5fdc8ffc-ab6d-4841-b7bb-66a33dcb28ad"), new DateTime(2024, 8, 26, 8, 17, 40, 752, DateTimeKind.Utc).AddTicks(7560), "example2@mail.com", "Doğa Su Türkileri", "BMrPPlghABqhCxSuh4/Irw==.7rCX9DslOTrYmuEg/+BUE90DWew69fdC+NdwnCbA0Rc=", false, new DateTime(2024, 8, 26, 8, 17, 40, 752, DateTimeKind.Utc).AddTicks(7560) },
                    { new Guid("62fe1503-a665-4f19-9e9a-27d212478f07"), new DateTime(2024, 8, 26, 8, 17, 40, 793, DateTimeKind.Utc).AddTicks(2000), "example8@mail.com", "Şahan Gökbakar", "zl+PpeKKO7mv0HKQitMkrg==.8exF8uhTxFEBKOiz02Z3tQ+yDB1062rUi52178JjZQA=", false, new DateTime(2024, 8, 26, 8, 17, 40, 793, DateTimeKind.Utc).AddTicks(2000) },
                    { new Guid("8f45ad14-1168-490c-87be-d753a5dae7ed"), new DateTime(2024, 8, 26, 8, 17, 40, 806, DateTimeKind.Utc).AddTicks(1190), "example10@mail.com", "Erkin Karaçay", "NivzNjWWEawzEaSeePT/1g==.tYc66j437N0Hr52mNVdcOOoql1K6htV3bCKlmgYvzpo=", false, new DateTime(2024, 8, 26, 8, 17, 40, 806, DateTimeKind.Utc).AddTicks(1190) },
                    { new Guid("d09ad47f-12f5-459c-a965-f84c55d2243c"), new DateTime(2024, 8, 26, 8, 17, 40, 799, DateTimeKind.Utc).AddTicks(6640), "example9@mail.com", "Mahsun Kırmızıgül", "8I5W8GZDsopQkVhrhxYSvA==.dqLxUSdIVsQEdd+wfdTVAxdIxyHGzDV8YSwktlL/MDA=", false, new DateTime(2024, 8, 26, 8, 17, 40, 799, DateTimeKind.Utc).AddTicks(6640) },
                    { new Guid("e98f715f-996f-4665-a313-d25a4745283c"), new DateTime(2024, 8, 26, 8, 17, 40, 819, DateTimeKind.Utc).AddTicks(6070), "example12@mail.com", "Barkın Özkaplan", "d8XGWjLVDJAyIAHRbemtsg==.s9KpkfpInp3EV7B8Pbw0JSml/PH/1jOu/3wxuCDDeTM=", false, new DateTime(2024, 8, 26, 8, 17, 40, 819, DateTimeKind.Utc).AddTicks(6070) },
                    { new Guid("eeb800f2-14f6-4b66-a123-c0c8cd5986f6"), new DateTime(2024, 8, 26, 8, 17, 40, 765, DateTimeKind.Utc).AddTicks(6620), "example4@mail.com", "Gamze Naz Yıldırım", "YMagb87AxVpC9RuiXtBTJw==.occqNeTp9zOI6Z08d+Drkzybt7hE8I1HgyZ+Ml9ipJ4=", false, new DateTime(2024, 8, 26, 8, 17, 40, 765, DateTimeKind.Utc).AddTicks(6620) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("0d365429-e505-4433-908f-d2e4ffd0b8f2"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("25fc7ef0-7c6a-432d-9a56-074b99d4d622"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("2d83f74b-036b-4ff2-a265-d73ef064ee51"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("4835cd2f-d076-41e3-8d85-99d07eb397ce"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("4dc08078-f24d-4ec7-b467-911ceaa6ef17"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("561b2425-b07e-44d1-bf09-f0c3f3a7c883"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("5acdf448-7e8b-4b72-958e-744fa70d6252"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("6754713d-5277-4775-9e32-75462ded4e40"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("6e33fd07-92c3-446f-a793-08c478ebdfad"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("9c90e391-d052-418f-a12f-8db5091fb9be"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0ad09f4d-f857-4ed8-b7a1-bb2f445bc3ea"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("10ccdcd2-2b86-4cca-9213-f1307483b730"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("33642377-872c-47f4-b26e-8d074c9b357e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("62513fdd-4ac0-4362-8396-ae7ff79c98b4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("633837ae-cccd-4d22-a7c6-6a79add972e9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8a7b240e-02fd-4b07-bf2f-fbcb69a7cf17"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8cab617b-2cf2-472f-a094-364d12f289f3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("91c0f984-113f-4b44-a8a0-42b111941e45"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("91eafcbe-b8fd-4561-8c64-d19c8654518f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("97f3ee84-c5af-44b0-b9cc-cdb283491659"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9a4134f8-190c-40fa-98ea-30cf6c88d29b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b05ca891-91f7-4bd7-887e-b3d479d5afc0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bf2b983d-988b-4710-87e1-f6110f7cc8d0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c603995c-a79d-4c25-b3a5-fa182df1ee33"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c9520333-2d09-4cbf-b3ac-f3914d1cb459"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e9fef5eb-f52a-44f6-9d03-d42f83989069"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f5c7dbb1-99af-48ee-92ad-3b82edfdf0a8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fe13a957-6c14-4742-b8fb-8fc6b5ada57d"));

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Orders",
                newName: "CustomerId");

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Email = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedDate", "Email", "Name", "Password", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("1196bdca-692d-4f4b-bfa9-672d10586bc2"), new DateTime(2024, 8, 12, 14, 49, 7, 56, DateTimeKind.Utc).AddTicks(3180), "example11@mail.com", "Ozan İmamhatipoğlu", "0L4+W9HIrA+Azn/ibW6+FA==.I/APi7pWdRtPZK3+GPjeZL+a85cfSH7AmOVzx2idUDA=", new DateTime(2024, 8, 12, 14, 49, 7, 56, DateTimeKind.Utc).AddTicks(3180) },
                    { new Guid("2076d73b-cbc8-4d67-a3a3-89965302e958"), new DateTime(2024, 8, 12, 14, 49, 7, 63, DateTimeKind.Utc).AddTicks(4750), "example12@mail.com", "Barkın Özkaplan", "rZkT7S3d+Rz2fXEhQ61uiw==.cUEc4aTKU2KjsaVIMZJT8F/Y2MNLOooEnkWQQYZZL8Y=", new DateTime(2024, 8, 12, 14, 49, 7, 63, DateTimeKind.Utc).AddTicks(4750) },
                    { new Guid("298f0f0f-2a46-40f4-8237-aa674dca05f6"), new DateTime(2024, 8, 12, 14, 49, 7, 23, DateTimeKind.Utc).AddTicks(4000), "example6@mail.com", "Ahmet Mümtaz Taylan", "qoyd5KDgEIgyQXLmfynRew==.aNg0/JQlgGuS8ae6Dl+f3HVP/Map9M4qsHzJtuKcCes=", new DateTime(2024, 8, 12, 14, 49, 7, 23, DateTimeKind.Utc).AddTicks(4000) },
                    { new Guid("3a5b71dc-d1d2-4009-bf32-1b19a3d2d0c0"), new DateTime(2024, 8, 12, 14, 49, 7, 8, DateTimeKind.Utc).AddTicks(5670), "example4@mail.com", "Gamze Naz Yıldırım", "EccMEWO4rcVJbKzsw1wwuQ==.hZxr5cpms+FDSn6ad7KMPQnbxrWl/SRaQ9F6m4yjFkg=", new DateTime(2024, 8, 12, 14, 49, 7, 8, DateTimeKind.Utc).AddTicks(5670) },
                    { new Guid("46856dc4-5e85-49e2-bf63-8cfdbc9a3b05"), new DateTime(2024, 8, 12, 14, 49, 6, 988, DateTimeKind.Utc).AddTicks(7170), "example1@mail.com", "Berke Öztürk", "RwHHjQ7j3KaP//GwdFfm8Q==.p+V+gRcadMH9TdpARysSdbp7sUm796sdyYG7C0d0LwI=", new DateTime(2024, 8, 12, 14, 49, 6, 988, DateTimeKind.Utc).AddTicks(7170) },
                    { new Guid("69a14f72-f9fb-49b7-9d9f-2b3f774deb64"), new DateTime(2024, 8, 12, 14, 49, 6, 995, DateTimeKind.Utc).AddTicks(3460), "example2@mail.com", "Doğa Su Türkileri", "Di3dOa7GxFomcIcVJkxTIw==.VtmlCixGZV1tFCx+vE3CsnBEz7eGXdcaVUODSxM6V1c=", new DateTime(2024, 8, 12, 14, 49, 6, 995, DateTimeKind.Utc).AddTicks(3460) },
                    { new Guid("71facde0-d11c-457d-9ff8-730159a88341"), new DateTime(2024, 8, 12, 14, 49, 7, 70, DateTimeKind.Utc).AddTicks(690), "example13@mail.com", "Barış Onur Aydın", "dqRVk5UORDtMrV+xQveygQ==.VC+29lQrJ3C304TlWMWkszGw+Vu6jQmCiPcsXFcFI7E=", new DateTime(2024, 8, 12, 14, 49, 7, 70, DateTimeKind.Utc).AddTicks(690) },
                    { new Guid("934da2eb-501b-4014-8ffc-66a2789975c9"), new DateTime(2024, 8, 12, 14, 49, 7, 43, DateTimeKind.Utc).AddTicks(1410), "example9@mail.com", "Mahsun Kırmızıgül", "6cHjoTop9yVRndChqM2oPA==.SugstybweOdAK6rR97PTkC+9Rv7VBfdCFaZGdoObBhQ=", new DateTime(2024, 8, 12, 14, 49, 7, 43, DateTimeKind.Utc).AddTicks(1410) },
                    { new Guid("9da9d768-a430-42c4-9e8d-8dec26a32110"), new DateTime(2024, 8, 12, 14, 49, 7, 49, DateTimeKind.Utc).AddTicks(7320), "example10@mail.com", "Erkin Karaçay", "oHR7nMSdQuBcz3Jxm4WUDg==.tLMgx2UCs2UKUDch2Kb5rFBSmO2DLbjsXlmw1cAwU8g=", new DateTime(2024, 8, 12, 14, 49, 7, 49, DateTimeKind.Utc).AddTicks(7320) },
                    { new Guid("9f5ed5e9-886e-48bb-b26a-f6b80e0ec7e2"), new DateTime(2024, 8, 12, 14, 49, 7, 1, DateTimeKind.Utc).AddTicks(9640), "example3@mail.com", "Ervin Parlak", "JNCoo6EGgksjt055q903mA==.mgwlP6fRgUjf9STn6H/hqE59PUS2YPgNLT3X0ttZDRA=", new DateTime(2024, 8, 12, 14, 49, 7, 1, DateTimeKind.Utc).AddTicks(9640) },
                    { new Guid("c400303e-5a12-49bb-9678-95ec0bde7f94"), new DateTime(2024, 8, 12, 14, 49, 7, 76, DateTimeKind.Utc).AddTicks(6500), "example14@mail.com", "Deniz Zarshat", "Tqdjdo7DhBEakOQ/IdQi7w==.Uzb+TcLB5gg4/KxAxMFElvGbWGcSfSILzffNSKBWpR4=", new DateTime(2024, 8, 12, 14, 49, 7, 76, DateTimeKind.Utc).AddTicks(6500) },
                    { new Guid("e217b370-03e0-4d4a-b4d2-4f01847a2f2b"), new DateTime(2024, 8, 12, 14, 49, 7, 36, DateTimeKind.Utc).AddTicks(5600), "example8@mail.com", "Şahan Gökbakar", "kSZ0TGsSFqN67BgcZpO/NQ==.4dj1IsjU5OEQ4iTKJom42uUkkscRX9KOZ4TA8tah3VA=", new DateTime(2024, 8, 12, 14, 49, 7, 36, DateTimeKind.Utc).AddTicks(5600) },
                    { new Guid("f341dfea-2d4f-41aa-aefb-ca3e12110f81"), new DateTime(2024, 8, 12, 14, 49, 7, 29, DateTimeKind.Utc).AddTicks(9760), "example7@mail.com", "Cem Yılmaz", "pi+upkWhmLTtVUu5nVXexg==.2ncD5TiM99gAb2qrIasGwZ7eGdxmjXFKARgX24DaBQY=", new DateTime(2024, 8, 12, 14, 49, 7, 29, DateTimeKind.Utc).AddTicks(9760) },
                    { new Guid("fa6ecf53-00c2-44ce-a967-8e20952ac1a6"), new DateTime(2024, 8, 12, 14, 49, 7, 16, DateTimeKind.Utc).AddTicks(8130), "example5@mail.com", "Atakan Yıldırım", "5nizkC5y+315T/vLrU/SVw==.ql1vP1qARzybUfBGVN6GravUQLG5Kj1i7CBoo0np46o=", new DateTime(2024, 8, 12, 14, 49, 7, 16, DateTimeKind.Utc).AddTicks(8130) }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "CreatedDate", "CustomerId", "Description", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("1167cb57-3733-4617-91ba-f4fbf4b7f4ff"), "4444 Aspen Court, Meadowbrook, OR 97001", new DateTime(2024, 8, 12, 14, 49, 7, 76, DateTimeKind.Utc).AddTicks(6780), new Guid("4efa7be4-ae10-41fc-8f36-2c233ba2e4f0"), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 8, 12, 14, 49, 7, 76, DateTimeKind.Utc).AddTicks(6780) },
                    { new Guid("5cce196d-483e-482d-a0af-6fc77414f2b7"), "789 Pine Lane, Rivertown, TX 75001", new DateTime(2024, 8, 12, 14, 49, 7, 76, DateTimeKind.Utc).AddTicks(6780), new Guid("dbf02731-121f-4205-a8d8-c8f020ca2ba6"), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 8, 12, 14, 49, 7, 76, DateTimeKind.Utc).AddTicks(6780) },
                    { new Guid("65388f87-6da2-4e87-b051-27c79eef6952"), "7777 Poplar Path, Brookhaven, GA 30301", new DateTime(2024, 8, 12, 14, 49, 7, 76, DateTimeKind.Utc).AddTicks(6800), new Guid("d498693f-b52f-4d62-8d5a-299011fc6219"), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 8, 12, 14, 49, 7, 76, DateTimeKind.Utc).AddTicks(6800) },
                    { new Guid("6bbbcbcf-b07a-4ff2-a1a8-eebceef132a9"), "10101 Juniper Avenue, Blue Ridge, NC 27501", new DateTime(2024, 8, 12, 14, 49, 7, 76, DateTimeKind.Utc).AddTicks(6760), new Guid("ce2f0b86-17f4-463e-9fc6-b6ba178da4de"), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 8, 12, 14, 49, 7, 76, DateTimeKind.Utc).AddTicks(6770) },
                    { new Guid("72603581-ce02-47cd-b49d-cf880999e49f"), "5555 Redwood Street, Greenfield, AZ 85001", new DateTime(2024, 8, 12, 14, 49, 7, 76, DateTimeKind.Utc).AddTicks(6790), new Guid("dd660ee3-9076-44f9-a8bd-753557b6e4e2"), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 8, 12, 14, 49, 7, 76, DateTimeKind.Utc).AddTicks(6790) },
                    { new Guid("7ef1842d-c735-4de7-a917-decd0d3cf90f"), "1010 Birch Road, Forestville, WA 98001", new DateTime(2024, 8, 12, 14, 49, 7, 76, DateTimeKind.Utc).AddTicks(6800), new Guid("b8e4eb7f-d312-45ff-a5e7-43a6746b92bf"), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 8, 12, 14, 49, 7, 76, DateTimeKind.Utc).AddTicks(6800) },
                    { new Guid("9ddaa299-ca19-407b-b61c-c6a6880ccc0f"), "9999 Spruce Place, Highland, UT 84003", new DateTime(2024, 8, 12, 14, 49, 7, 76, DateTimeKind.Utc).AddTicks(6770), new Guid("efc859b7-bff5-418c-881a-2dc224ec00cd"), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 8, 12, 14, 49, 7, 76, DateTimeKind.Utc).AddTicks(6770) },
                    { new Guid("c8b16188-583d-471f-b8ed-7976fab8f70d"), "8888 Cypress Circle, Riverview, MI 48201", new DateTime(2024, 8, 12, 14, 49, 7, 76, DateTimeKind.Utc).AddTicks(6810), new Guid("14badc68-83f7-4964-bf64-4348a68e2808"), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 8, 12, 14, 49, 7, 76, DateTimeKind.Utc).AddTicks(6810) },
                    { new Guid("ce2532db-6973-4561-8584-86398c6b2be9"), "456 Elm Avenue, Oakville, CA 94022", new DateTime(2024, 8, 12, 14, 49, 7, 76, DateTimeKind.Utc).AddTicks(6760), new Guid("82b1e376-c3dd-4d2c-ab82-6f6e08d60839"), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 8, 12, 14, 49, 7, 76, DateTimeKind.Utc).AddTicks(6760) },
                    { new Guid("cf1834cb-76bc-464c-b881-a5379c218e03"), "2222 Oak Drive, Hillcrest, NY 10001", new DateTime(2024, 8, 12, 14, 49, 7, 76, DateTimeKind.Utc).AddTicks(6750), new Guid("4fb44a49-cfcd-440f-91f0-ad17d09d9c5b"), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 8, 12, 14, 49, 7, 76, DateTimeKind.Utc).AddTicks(6750) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "ImageUrl", "Name", "Price", "Stock", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("1a01a99a-b6dc-4ad7-9f11-61d6d12a7909"), new Guid("d27d9bdd-890e-4501-bc57-d28958007ef2"), new DateTime(2024, 8, 12, 14, 49, 7, 76, DateTimeKind.Utc).AddTicks(6870), "A smart home security camera with night vision and motion detection. Connects to your smartphone.", " ", "FirNest Home Security Camera", 99.989999999999995, 100.0, new DateTime(2024, 8, 12, 14, 49, 7, 76, DateTimeKind.Utc).AddTicks(6870) },
                    { new Guid("39048274-1b85-40c8-88c8-61267ef244ae"), new Guid("77860c4e-e20e-47d7-a447-cbc04eda6aca"), new DateTime(2024, 8, 12, 14, 49, 7, 76, DateTimeKind.Utc).AddTicks(6900), "An insulated water bottle that keeps drinks hot or cold for hours. Made from stainless steel.", " ", "JuniperPure Water Bottle", 24.989999999999998, 400.0, new DateTime(2024, 8, 12, 14, 49, 7, 76, DateTimeKind.Utc).AddTicks(6900) },
                    { new Guid("4408d508-a7ed-4545-99f2-648f31a94b15"), new Guid("eb0cc970-cccf-4ab3-a041-21e0a9b68430"), new DateTime(2024, 8, 12, 14, 49, 7, 76, DateTimeKind.Utc).AddTicks(6870), "A powerful gaming laptop with high-end graphics and fast processing speed. Ideal for gamers.", " ", "RedwoodX Gaming Laptop", 1299.99, 30.0, new DateTime(2024, 8, 12, 14, 49, 7, 76, DateTimeKind.Utc).AddTicks(6870) },
                    { new Guid("4956083a-28c9-454e-a95c-c38eb4d3ad33"), new Guid("ed7f3461-1544-4a04-8477-771834a35740"), new DateTime(2024, 8, 12, 14, 49, 7, 76, DateTimeKind.Utc).AddTicks(6910), "A contemporary table lamp with touch control and adjustable brightness. Perfect for any room.", " ", "ElmGlow Table Lamp", 34.990000000000002, 140.0, new DateTime(2024, 8, 12, 14, 49, 7, 76, DateTimeKind.Utc).AddTicks(6910) },
                    { new Guid("58011a47-b8a6-47cd-abb0-014755326b2e"), new Guid("e68801c3-3229-4f8b-b76d-53cfe229f0cd"), new DateTime(2024, 8, 12, 14, 49, 7, 76, DateTimeKind.Utc).AddTicks(6930), "High-quality wireless earbuds with noise cancellation and long battery life. Comes with a chargingcase.", " ", "BirchSound Wireless Earbuds", 79.989999999999995, 300.0, new DateTime(2024, 8, 12, 14, 49, 7, 76, DateTimeKind.Utc).AddTicks(6930) },
                    { new Guid("6b99a619-e692-4b77-91c6-dc9aa69389e6"), new Guid("f51eefa3-3871-48cd-b442-39819c078705"), new DateTime(2024, 8, 12, 14, 49, 7, 76, DateTimeKind.Utc).AddTicks(6850), "A portable Bluetooth speaker with high-quality sound and long battery life. Perfectforoutdooractivities.", " ", "WillowWave Bluetooth Speaker", 59.990000000000002, 250.0, new DateTime(2024, 8, 12, 14, 49, 7, 76, DateTimeKind.Utc).AddTicks(6850) },
                    { new Guid("7af4b8d3-9c92-4077-acaf-6135b2183203"), new Guid("a3d611e6-2c8a-4190-9381-e4af896ee08b"), new DateTime(2024, 8, 12, 14, 49, 7, 76, DateTimeKind.Utc).AddTicks(6860), "A stylish LED lamp with adjustable brightness and color temperature. Ideal for reading and working.", " ", "AspenGlow LED Lamp", 39.990000000000002, 180.0, new DateTime(2024, 8, 12, 14, 49, 7, 76, DateTimeKind.Utc).AddTicks(6860) },
                    { new Guid("823c6a14-1e90-479a-9eef-e351307a606d"), new Guid("fcbd5e16-0309-4872-902a-8dfad346f799"), new DateTime(2024, 8, 12, 14, 49, 7, 76, DateTimeKind.Utc).AddTicks(6850), "Lightweight and comfortable running shoes with breathable mesh and cushioned sole.", " ", "OakHill Running Shoes", 89.989999999999995, 300.0, new DateTime(2024, 8, 12, 14, 49, 7, 76, DateTimeKind.Utc).AddTicks(6850) },
                    { new Guid("98e9eafa-7d7d-4795-9318-8047aa68f4cc"), new Guid("29bbaa2a-0e6a-434a-8872-d6ebd37b4cf7"), new DateTime(2024, 8, 12, 14, 49, 7, 76, DateTimeKind.Utc).AddTicks(6930), "A programmable coffee maker with a built-in grinder and timer. Makes up to 12 cups of coffee.", " ", "OakPure Coffee Maker", 129.99000000000001, 90.0, new DateTime(2024, 8, 12, 14, 49, 7, 76, DateTimeKind.Utc).AddTicks(6930) },
                    { new Guid("9cbb9f00-ab13-4c56-94a5-96057560172f"), new Guid("d71bd56b-705c-4da6-8b6e-21c812d3b085"), new DateTime(2024, 8, 12, 14, 49, 7, 76, DateTimeKind.Utc).AddTicks(6940), "A lightweight and durable camping tent that accommodates up to 4 people. Easy to set up.", " ", "WillowLite Camping Tent", 199.99000000000001, 70.0, new DateTime(2024, 8, 12, 14, 49, 7, 76, DateTimeKind.Utc).AddTicks(6940) },
                    { new Guid("a7aa39fa-cfc6-4f71-be18-7d400d977d39"), new Guid("418ce8cc-5e10-469b-87f3-2162b6ebce90"), new DateTime(2024, 8, 12, 14, 49, 7, 76, DateTimeKind.Utc).AddTicks(6920), "A professional kitchen knife set with high-carbon stainless steel blades. Includes 6 knives and ablock.", " ", "PineEdge Kitchen Knife Set", 89.989999999999995, 85.0, new DateTime(2024, 8, 12, 14, 49, 7, 76, DateTimeKind.Utc).AddTicks(6920) },
                    { new Guid("b44d2758-a173-4bc0-8a68-3ac0053d72ad"), new Guid("ecd68670-6401-4c42-9026-d3a89b703b8b"), new DateTime(2024, 8, 12, 14, 49, 7, 76, DateTimeKind.Utc).AddTicks(6880), "A fitness tracker with heart rate monitoring, step counting, and sleep tracking. Waterproof design.", " ", "PoplarPulse Fitness Tracker", 49.990000000000002, 220.0, new DateTime(2024, 8, 12, 14, 49, 7, 76, DateTimeKind.Utc).AddTicks(6880) },
                    { new Guid("c6636e32-ee1b-4326-81b9-5d6e2ca65ee3"), new Guid("c62c50c2-371e-4e3a-aa47-bd7a60d6d755"), new DateTime(2024, 8, 12, 14, 49, 7, 76, DateTimeKind.Utc).AddTicks(6910), "A durable and flexible smartphone case that provides excellent protection. Compatible with most models.", " ", "MapleFlex Smartphone Case", 19.989999999999998, 350.0, new DateTime(2024, 8, 12, 14, 49, 7, 76, DateTimeKind.Utc).AddTicks(6910) },
                    { new Guid("d280b94d-ec89-43c9-a553-fea33dd69285"), new Guid("c57a99ee-e5c6-4705-9ea0-fdcb68d8078c"), new DateTime(2024, 8, 12, 14, 49, 7, 76, DateTimeKind.Utc).AddTicks(6840), "An ergonomic office chair with adjustable height and lumbar support. Ideal for long hours of work.", " ", "BirchCraft Office Chair", 149.99000000000001, 150.0, new DateTime(2024, 8, 12, 14, 49, 7, 76, DateTimeKind.Utc).AddTicks(6840) },
                    { new Guid("de84e562-7e86-4ee4-8cf0-5933d1aed2aa"), new Guid("37019549-da5f-43ba-9c2e-ecadc5f50851"), new DateTime(2024, 8, 12, 14, 49, 7, 76, DateTimeKind.Utc).AddTicks(6890), "A non-slip yoga mat with extra cushioning for comfort. Perfect for yoga and pilates.", " ", "CypressFlow Yoga Mat", 29.989999999999998, 500.0, new DateTime(2024, 8, 12, 14, 49, 7, 76, DateTimeKind.Utc).AddTicks(6890) },
                    { new Guid("e3dd8313-e6b5-4bbc-87d1-cbe35a719e70"), new Guid("e9654245-9daf-4191-be37-f3dd49a76bbe"), new DateTime(2024, 8, 12, 14, 49, 7, 76, DateTimeKind.Utc).AddTicks(6890), "A high-performance drone with HD camera and long battery life. Ideal for aerial photography.", " ", "SpruceSky Drone", 349.99000000000001, 60.0, new DateTime(2024, 8, 12, 14, 49, 7, 76, DateTimeKind.Utc).AddTicks(6890) },
                    { new Guid("f1e75dd1-0eec-4633-a0ee-4f28f39cc476"), new Guid("2b79a453-28d1-4132-897e-d61a55537159"), new DateTime(2024, 8, 12, 14, 49, 7, 76, DateTimeKind.Utc).AddTicks(6950), "A high-capacity power bank with fast charging technology. Compatible with all USB devices.", " ", "RedwoodMax Power Bank", 39.990000000000002, 250.0, new DateTime(2024, 8, 12, 14, 49, 7, 76, DateTimeKind.Utc).AddTicks(6950) },
                    { new Guid("f72946a5-52aa-4424-8dbe-9d3aa3e5ad81"), new Guid("4a77e62a-59e5-4a8a-832b-557f9f17c89f"), new DateTime(2024, 8, 12, 14, 49, 7, 76, DateTimeKind.Utc).AddTicks(6940), "A compact mini fridge with adjustable temperature settings. Perfect for dorm rooms and offices.", " ", "AspenCool Mini Fridge", 149.99000000000001, 120.0, new DateTime(2024, 8, 12, 14, 49, 7, 76, DateTimeKind.Utc).AddTicks(6940) }
                });
        }
    }
}
