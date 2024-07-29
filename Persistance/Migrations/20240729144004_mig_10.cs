using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistance.Migrations
{
    /// <inheritdoc />
    public partial class mig_10 : Migration
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
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    Password = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uuid", nullable: false),
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
                    Description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    Stock = table.Column<double>(type: "double precision", nullable: false),
                    Price = table.Column<double>(type: "double precision", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedDate", "Email", "Name", "Password", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("1574c5a5-eaac-4627-a3a1-4f154d779280"), new DateTime(2024, 7, 29, 14, 40, 4, 191, DateTimeKind.Utc).AddTicks(6760), "example13@mail.com", "Barış Onur Aydın", "XZvGMmcpRIRQ4ij/QUJv4vNnKosFQ1HoMyRTNstSP8U=", new DateTime(2024, 7, 29, 14, 40, 4, 191, DateTimeKind.Utc).AddTicks(6760) },
                    { new Guid("17c157ea-ea01-4501-897b-08a762e1539d"), new DateTime(2024, 7, 29, 14, 40, 4, 142, DateTimeKind.Utc).AddTicks(2590), "example5@mail.com", "Atakan Yıldırım", "4Dim7oiKc4+2QPXLWAnb7u8FIyDrVvQPz4eoasJp72w=", new DateTime(2024, 7, 29, 14, 40, 4, 142, DateTimeKind.Utc).AddTicks(2590) },
                    { new Guid("2d1027eb-593b-438c-a0a5-dab66c3f5e27"), new DateTime(2024, 7, 29, 14, 40, 4, 185, DateTimeKind.Utc).AddTicks(5880), "example12@mail.com", "Barkın Özkaplan", "67pGUJ62P6tGT+eXz4miZkWFLsJyz19HL6uNVPJHTO0=", new DateTime(2024, 7, 29, 14, 40, 4, 185, DateTimeKind.Utc).AddTicks(5880) },
                    { new Guid("41a7a8c4-fdcd-4266-adc4-a5f3915cc20b"), new DateTime(2024, 7, 29, 14, 40, 4, 154, DateTimeKind.Utc).AddTicks(5420), "example7@mail.com", "Cem Yılmaz", "9ezQBox1rnCK+yOiPjduKD+fodzr5OOeyXdAuh7BGzM=", new DateTime(2024, 7, 29, 14, 40, 4, 154, DateTimeKind.Utc).AddTicks(5420) },
                    { new Guid("764abf2f-a4d3-4e8e-98e3-f4e501bdae0c"), new DateTime(2024, 7, 29, 14, 40, 4, 148, DateTimeKind.Utc).AddTicks(3970), "example6@mail.com", "Ahmet Mümtaz Taylan", "xCRJNghD4RxLFXd3T7Tu8WS4aePqZyY0Fmv/GKyS9q4=", new DateTime(2024, 7, 29, 14, 40, 4, 148, DateTimeKind.Utc).AddTicks(3970) },
                    { new Guid("92474f7d-70ee-430e-80fb-c4ab74c5ddbe"), new DateTime(2024, 7, 29, 14, 40, 4, 134, DateTimeKind.Utc).AddTicks(4210), "example4@mail.com", "Gamze Naz Yıldırım", "3jx5Ce8sgeA1EP5Lgd0MIcBlnRjn2bk7RBi5Yi7E2Ng=", new DateTime(2024, 7, 29, 14, 40, 4, 134, DateTimeKind.Utc).AddTicks(4210) },
                    { new Guid("9de7b83c-0d07-47af-b98e-6884519b68d5"), new DateTime(2024, 7, 29, 14, 40, 4, 166, DateTimeKind.Utc).AddTicks(7480), "example9@mail.com", "Mahsun Kırmızıgül", "zXhWrrk5YLmI0EHCEdVX0MU0Z0BU7OlZ2CQXtQfN+Dw=", new DateTime(2024, 7, 29, 14, 40, 4, 166, DateTimeKind.Utc).AddTicks(7480) },
                    { new Guid("a44c91dd-e978-4b75-8efa-fea0135b3cd6"), new DateTime(2024, 7, 29, 14, 40, 4, 115, DateTimeKind.Utc).AddTicks(5910), "example1@mail.com", "Berke Öztürk", "G5OZmLjVFiadwqIxAlUK0QOz+suIAeDM1hcL+JY8GSc=", new DateTime(2024, 7, 29, 14, 40, 4, 115, DateTimeKind.Utc).AddTicks(5910) },
                    { new Guid("a7a8ac66-721f-437f-9ca2-ab91b017405a"), new DateTime(2024, 7, 29, 14, 40, 4, 172, DateTimeKind.Utc).AddTicks(8700), "example10@mail.com", "Erkin Karaçay", "tRhpVUl5mRe9n5hPcyjUhH/ZvttHt+9PuCHe30X3ngY=", new DateTime(2024, 7, 29, 14, 40, 4, 172, DateTimeKind.Utc).AddTicks(8700) },
                    { new Guid("a943810d-1ed5-4d6e-a72b-37288197de53"), new DateTime(2024, 7, 29, 14, 40, 4, 121, DateTimeKind.Utc).AddTicks(9820), "example2@mail.com", "Doğa Su Türkileri", "ekf3DGLYwCm85q3SMnJlebSHL78d+tf0Io7LQZ8qSac=", new DateTime(2024, 7, 29, 14, 40, 4, 121, DateTimeKind.Utc).AddTicks(9820) },
                    { new Guid("b864c69f-bb05-4af6-8830-de7c889ba2cd"), new DateTime(2024, 7, 29, 14, 40, 4, 128, DateTimeKind.Utc).AddTicks(2520), "example3@mail.com", "Ervin Parlak", "F+0/bzdyBsWqn2k3QLbMVKMo6pkI9QyeSXRQa+9THy4=", new DateTime(2024, 7, 29, 14, 40, 4, 128, DateTimeKind.Utc).AddTicks(2520) },
                    { new Guid("cca027b5-5d27-406a-9d70-241285b6c021"), new DateTime(2024, 7, 29, 14, 40, 4, 160, DateTimeKind.Utc).AddTicks(6400), "example8@mail.com", "Şahan Gökbakar", "fIkEDckDcFAz7rm82kBY8+76jH3MeTQ9QGWAtxDgHiU=", new DateTime(2024, 7, 29, 14, 40, 4, 160, DateTimeKind.Utc).AddTicks(6400) },
                    { new Guid("d7f9084d-c1da-45ac-b8e0-d095f467305c"), new DateTime(2024, 7, 29, 14, 40, 4, 178, DateTimeKind.Utc).AddTicks(9980), "example11@mail.com", "Ozan İmamhatipoğlu", "EdcBcJ8iKXqsXnPF7ylNN8jv3Kjx4ox5bU1YCZPaTtg=", new DateTime(2024, 7, 29, 14, 40, 4, 178, DateTimeKind.Utc).AddTicks(9980) },
                    { new Guid("ec98ee00-c824-4666-aafa-b932e569203b"), new DateTime(2024, 7, 29, 14, 40, 4, 197, DateTimeKind.Utc).AddTicks(6690), "example14@mail.com", "Deniz Zarshat", "D1A3oRXnOikirXRt3UYGUv2z11iQgwBzq4xpE8GzUdk=", new DateTime(2024, 7, 29, 14, 40, 4, 197, DateTimeKind.Utc).AddTicks(6690) }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "CreatedDate", "CustomerId", "Description", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("2b7174a8-e388-4584-bfdc-047249d80924"), "4444 Aspen Court, Meadowbrook, OR 97001", new DateTime(2024, 7, 29, 14, 40, 4, 197, DateTimeKind.Utc).AddTicks(6880), new Guid("bbe61aae-85db-4fdf-a226-52020a680d01"), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 7, 29, 14, 40, 4, 197, DateTimeKind.Utc).AddTicks(6880) },
                    { new Guid("42134d94-1b79-459a-a269-59076cfc6d2f"), "456 Elm Avenue, Oakville, CA 94022", new DateTime(2024, 7, 29, 14, 40, 4, 197, DateTimeKind.Utc).AddTicks(6860), new Guid("12e6b107-eb5b-4fc3-a76c-72ff53789db4"), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 7, 29, 14, 40, 4, 197, DateTimeKind.Utc).AddTicks(6860) },
                    { new Guid("6025fb7d-cb29-401a-86ab-bf74a21c64f8"), "10101 Juniper Avenue, Blue Ridge, NC 27501", new DateTime(2024, 7, 29, 14, 40, 4, 197, DateTimeKind.Utc).AddTicks(6860), new Guid("7f713619-576e-4528-b821-ddf9d0a0000a"), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 7, 29, 14, 40, 4, 197, DateTimeKind.Utc).AddTicks(6860) },
                    { new Guid("60b56e23-2305-42ca-80c6-a0dc9fd04cad"), "7777 Poplar Path, Brookhaven, GA 30301", new DateTime(2024, 7, 29, 14, 40, 4, 197, DateTimeKind.Utc).AddTicks(6900), new Guid("26eca96a-77d8-4448-97d0-df46ba00fc40"), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 7, 29, 14, 40, 4, 197, DateTimeKind.Utc).AddTicks(6900) },
                    { new Guid("68967530-a4cc-4dc9-9593-11b0c181664a"), "8888 Cypress Circle, Riverview, MI 48201", new DateTime(2024, 7, 29, 14, 40, 4, 197, DateTimeKind.Utc).AddTicks(6910), new Guid("e32a838d-ee1b-4e24-b6a9-8697131eaa3b"), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 7, 29, 14, 40, 4, 197, DateTimeKind.Utc).AddTicks(6910) },
                    { new Guid("8030d00e-7304-498a-b4dc-9a6e7d0ae338"), "2222 Oak Drive, Hillcrest, NY 10001", new DateTime(2024, 7, 29, 14, 40, 4, 197, DateTimeKind.Utc).AddTicks(6850), new Guid("70231cce-0530-40c4-916d-f2e6122e40f4"), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 7, 29, 14, 40, 4, 197, DateTimeKind.Utc).AddTicks(6850) },
                    { new Guid("894bea55-364f-4dac-b0a2-09707f411eb4"), "1010 Birch Road, Forestville, WA 98001", new DateTime(2024, 7, 29, 14, 40, 4, 197, DateTimeKind.Utc).AddTicks(6900), new Guid("f205e09b-acce-4781-a212-ef5ee3180339"), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 7, 29, 14, 40, 4, 197, DateTimeKind.Utc).AddTicks(6910) },
                    { new Guid("8e32e065-8275-4652-a15c-c6d9ca4ea815"), "9999 Spruce Place, Highland, UT 84003", new DateTime(2024, 7, 29, 14, 40, 4, 197, DateTimeKind.Utc).AddTicks(6870), new Guid("54d7e148-18c5-4677-96f4-0b60348fbb96"), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 7, 29, 14, 40, 4, 197, DateTimeKind.Utc).AddTicks(6870) },
                    { new Guid("9c815b78-97bd-4040-aae6-4f63290ae46f"), "789 Pine Lane, Rivertown, TX 75001", new DateTime(2024, 7, 29, 14, 40, 4, 197, DateTimeKind.Utc).AddTicks(6890), new Guid("033e9422-2800-4afc-858d-fbaa2d1a8597"), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 7, 29, 14, 40, 4, 197, DateTimeKind.Utc).AddTicks(6890) },
                    { new Guid("e2ca0f14-5252-48ac-836c-cb000b0aaf60"), "5555 Redwood Street, Greenfield, AZ 85001", new DateTime(2024, 7, 29, 14, 40, 4, 197, DateTimeKind.Utc).AddTicks(6890), new Guid("75ca78fc-2f7e-4594-b8c0-e872209ce250"), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 7, 29, 14, 40, 4, 197, DateTimeKind.Utc).AddTicks(6890) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "Name", "Price", "Stock", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("08667153-bf9d-4915-8f84-001916476eeb"), new Guid("a16f567b-5b84-4398-917c-c5ac5d998b7f"), new DateTime(2024, 7, 29, 14, 40, 4, 197, DateTimeKind.Utc).AddTicks(6960), "A powerful gaming laptop with high-end graphics and fast processing speed. Ideal for gamers.", "RedwoodX Gaming Laptop", 1299.99, 30.0, new DateTime(2024, 7, 29, 14, 40, 4, 197, DateTimeKind.Utc).AddTicks(6960) },
                    { new Guid("0fc2d043-0714-4a4d-ab96-e9b73a21e9e5"), new Guid("67afe7d7-ea69-48c1-9979-a74d4f9bfc72"), new DateTime(2024, 7, 29, 14, 40, 4, 197, DateTimeKind.Utc).AddTicks(6950), "A portable Bluetooth speaker with high-quality sound and long battery life. Perfectforoutdooractivities.", "WillowWave Bluetooth Speaker", 59.990000000000002, 250.0, new DateTime(2024, 7, 29, 14, 40, 4, 197, DateTimeKind.Utc).AddTicks(6950) },
                    { new Guid("154a678d-8b66-4467-90c9-9a6fe9a08971"), new Guid("38563825-e48f-4166-9dcd-be27bdb2baaf"), new DateTime(2024, 7, 29, 14, 40, 4, 197, DateTimeKind.Utc).AddTicks(6940), "An ergonomic office chair with adjustable height and lumbar support. Ideal for long hours of work.", "BirchCraft Office Chair", 149.99000000000001, 150.0, new DateTime(2024, 7, 29, 14, 40, 4, 197, DateTimeKind.Utc).AddTicks(6940) },
                    { new Guid("2dc5979e-2185-45ee-9adf-00b9daedfa00"), new Guid("9f644a59-c6b3-4c66-acb8-c4d5398ed136"), new DateTime(2024, 7, 29, 14, 40, 4, 197, DateTimeKind.Utc).AddTicks(6950), "Lightweight and comfortable running shoes with breathable mesh and cushioned sole.", "OakHill Running Shoes", 89.989999999999995, 300.0, new DateTime(2024, 7, 29, 14, 40, 4, 197, DateTimeKind.Utc).AddTicks(6950) },
                    { new Guid("39e167dd-00e9-42a1-bc0a-cf4f2c0b4c6d"), new Guid("5e4e264d-e5ad-4160-8aa6-cdf608c766ae"), new DateTime(2024, 7, 29, 14, 40, 4, 197, DateTimeKind.Utc).AddTicks(7030), "A lightweight and durable camping tent that accommodates up to 4 people. Easy to set up.", "WillowLite Camping Tent", 199.99000000000001, 70.0, new DateTime(2024, 7, 29, 14, 40, 4, 197, DateTimeKind.Utc).AddTicks(7030) },
                    { new Guid("3a0320f0-a2ce-4580-8d36-b136f0005d8c"), new Guid("403f5b02-d059-42be-b644-ea1d6fd3a833"), new DateTime(2024, 7, 29, 14, 40, 4, 197, DateTimeKind.Utc).AddTicks(6960), "A stylish LED lamp with adjustable brightness and color temperature. Ideal for reading and working.", "AspenGlow LED Lamp", 39.990000000000002, 180.0, new DateTime(2024, 7, 29, 14, 40, 4, 197, DateTimeKind.Utc).AddTicks(6960) },
                    { new Guid("657f3107-e583-4bf5-a19c-cec337d83f3c"), new Guid("285e9f5d-9f6f-4eb0-8975-ca83190bc541"), new DateTime(2024, 7, 29, 14, 40, 4, 197, DateTimeKind.Utc).AddTicks(7000), "A durable and flexible smartphone case that provides excellent protection. Compatible with most models.", "MapleFlex Smartphone Case", 19.989999999999998, 350.0, new DateTime(2024, 7, 29, 14, 40, 4, 197, DateTimeKind.Utc).AddTicks(7000) },
                    { new Guid("71874edc-e11b-4c3f-8299-a81f91c40cc2"), new Guid("bfb4778f-44b2-456b-ad6f-f05e1f9c03e8"), new DateTime(2024, 7, 29, 14, 40, 4, 197, DateTimeKind.Utc).AddTicks(6980), "A non-slip yoga mat with extra cushioning for comfort. Perfect for yoga and pilates.", "CypressFlow Yoga Mat", 29.989999999999998, 500.0, new DateTime(2024, 7, 29, 14, 40, 4, 197, DateTimeKind.Utc).AddTicks(6980) },
                    { new Guid("810d90ef-56f5-48ea-8682-d38b9fcc61e8"), new Guid("c2e85e5a-92d6-4a08-a0ef-567d18f54e84"), new DateTime(2024, 7, 29, 14, 40, 4, 197, DateTimeKind.Utc).AddTicks(7040), "A compact mini fridge with adjustable temperature settings. Perfect for dorm rooms and offices.", "AspenCool Mini Fridge", 149.99000000000001, 120.0, new DateTime(2024, 7, 29, 14, 40, 4, 197, DateTimeKind.Utc).AddTicks(7040) },
                    { new Guid("872d3421-5038-49e1-8a15-008068ea46fa"), new Guid("dc585a8a-b9d5-4c56-86e2-20a13fec79c1"), new DateTime(2024, 7, 29, 14, 40, 4, 197, DateTimeKind.Utc).AddTicks(7020), "High-quality wireless earbuds with noise cancellation and long battery life. Comes with a chargingcase.", "BirchSound Wireless Earbuds", 79.989999999999995, 300.0, new DateTime(2024, 7, 29, 14, 40, 4, 197, DateTimeKind.Utc).AddTicks(7020) },
                    { new Guid("8b92dfd3-d7b7-40aa-a6b4-7b1bd1597719"), new Guid("caddc477-7ed0-4c2f-84ac-2f0093ef1394"), new DateTime(2024, 7, 29, 14, 40, 4, 197, DateTimeKind.Utc).AddTicks(7000), "An insulated water bottle that keeps drinks hot or cold for hours. Made from stainless steel.", "JuniperPure Water Bottle", 24.989999999999998, 400.0, new DateTime(2024, 7, 29, 14, 40, 4, 197, DateTimeKind.Utc).AddTicks(7000) },
                    { new Guid("8f1509cd-e282-4b0f-ab82-4b457ea90ebc"), new Guid("fc3daa74-0b85-438e-8e87-8a7db31df605"), new DateTime(2024, 7, 29, 14, 40, 4, 197, DateTimeKind.Utc).AddTicks(7040), "A high-capacity power bank with fast charging technology. Compatible with all USB devices.", "RedwoodMax Power Bank", 39.990000000000002, 250.0, new DateTime(2024, 7, 29, 14, 40, 4, 197, DateTimeKind.Utc).AddTicks(7040) },
                    { new Guid("a5d7bf2a-c07a-4f11-93fc-f20556bd930e"), new Guid("a266e915-9ea9-489d-9f90-c25dba1acb58"), new DateTime(2024, 7, 29, 14, 40, 4, 197, DateTimeKind.Utc).AddTicks(7010), "A professional kitchen knife set with high-carbon stainless steel blades. Includes 6 knives and ablock.", "PineEdge Kitchen Knife Set", 89.989999999999995, 85.0, new DateTime(2024, 7, 29, 14, 40, 4, 197, DateTimeKind.Utc).AddTicks(7010) },
                    { new Guid("a6d17b8b-5c6a-4482-9a57-6a457782c0a5"), new Guid("3d5c72a6-3fc4-404e-9f76-f8554182849e"), new DateTime(2024, 7, 29, 14, 40, 4, 197, DateTimeKind.Utc).AddTicks(6970), "A smart home security camera with night vision and motion detection. Connects to your smartphone.", "FirNest Home Security Camera", 99.989999999999995, 100.0, new DateTime(2024, 7, 29, 14, 40, 4, 197, DateTimeKind.Utc).AddTicks(6970) },
                    { new Guid("bb1d520a-fb43-4ca6-9718-49745d4222e6"), new Guid("8f6d99a3-13d6-49f2-9643-1234d886ee62"), new DateTime(2024, 7, 29, 14, 40, 4, 197, DateTimeKind.Utc).AddTicks(6990), "A high-performance drone with HD camera and long battery life. Ideal for aerial photography.", "SpruceSky Drone", 349.99000000000001, 60.0, new DateTime(2024, 7, 29, 14, 40, 4, 197, DateTimeKind.Utc).AddTicks(6990) },
                    { new Guid("c9683cb5-a495-482c-bc28-9daefabc5c63"), new Guid("a4482f7e-9184-4b75-8a54-378be8939bea"), new DateTime(2024, 7, 29, 14, 40, 4, 197, DateTimeKind.Utc).AddTicks(7030), "A programmable coffee maker with a built-in grinder and timer. Makes up to 12 cups of coffee.", "OakPure Coffee Maker", 129.99000000000001, 90.0, new DateTime(2024, 7, 29, 14, 40, 4, 197, DateTimeKind.Utc).AddTicks(7030) },
                    { new Guid("dcd2c947-6079-4529-b92b-0da24e40f26e"), new Guid("8bb87764-34f0-4a1d-aa2a-7c46ef8275b8"), new DateTime(2024, 7, 29, 14, 40, 4, 197, DateTimeKind.Utc).AddTicks(6980), "A fitness tracker with heart rate monitoring, step counting, and sleep tracking. Waterproof design.", "PoplarPulse Fitness Tracker", 49.990000000000002, 220.0, new DateTime(2024, 7, 29, 14, 40, 4, 197, DateTimeKind.Utc).AddTicks(6980) },
                    { new Guid("f5ce7751-8e6b-42e8-b2c3-29ff1a3a36a7"), new Guid("b99a3cbe-8560-4257-9581-e96c4f132963"), new DateTime(2024, 7, 29, 14, 40, 4, 197, DateTimeKind.Utc).AddTicks(7010), "A contemporary table lamp with touch control and adjustable brightness. Perfect for any room.", "ElmGlow Table Lamp", 34.990000000000002, 140.0, new DateTime(2024, 7, 29, 14, 40, 4, 197, DateTimeKind.Utc).AddTicks(7010) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
