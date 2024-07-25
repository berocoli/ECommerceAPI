using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistance.Migrations
{
    /// <inheritdoc />
    public partial class mig_7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("334b725c-c51a-4239-a97a-0247eafac600"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("36581f97-a442-492d-bfe6-e6cc01a05b95"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("40b70c62-0bd2-4f60-9375-170f899caddd"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("426fab99-9c25-408d-9b59-5381ecfee7cb"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("4f70160b-e0fe-4f02-b367-2711e3ec09b3"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("5d9ba5f9-05bf-47df-b155-65b0db94ac4c"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("6f9c3387-32d1-4352-bb2b-9b55ee564339"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("6ff2f372-516d-4acc-8018-c47baf771fc0"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("79922af9-58bd-440f-ba27-894ba58a9753"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("8a3ec824-4dfb-4578-a7ef-1d80b04f7f74"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("9ba3d168-2636-4e91-a2ce-fac2d26b1c10"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("caa2cfdd-8102-43aa-876d-d05b82b99774"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("cca7f8b1-7918-48d8-ac84-4d5b4854c96d"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("f1e37b6d-1b56-4b73-b920-5671eabcd82a"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("04b22a55-b9cf-43b3-8991-46fb1ac918f0"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("0d0ad0ed-fae3-4f11-a9db-5f7fa68f06b2"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("4067b7e8-641b-4975-95ff-edf6e7e70031"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("4437e6ba-bf29-4ed0-97d8-33b28ab907c4"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("6c178372-e5d1-4792-a54b-69d8f93cbb60"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("7f3190a1-de27-4fd6-a871-8e3eaec439cd"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("8e532579-afbf-44b8-b404-1a6cab29e62f"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("992fe19f-d6b7-4060-9702-c5cad5421d6f"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("cd17ad98-6b38-497a-9af8-d515fe668287"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("dfd7724a-440f-4528-8283-9afd5202db71"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0aa6804c-b34c-4160-a678-eee372f7f939"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2d4c69c8-ec2d-4db2-934a-f0c6631a9778"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("31c73a76-a11f-48de-8820-e9bb95c85aab"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3d169583-70cf-40ea-92ff-68e40259fc1b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4ba932ff-e2b9-42ef-8891-6d45158ba08d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5e41c522-22b8-4066-9d3c-6c3ee0f6e91c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("66d31bdc-e187-4d7a-a6a2-b5396e9f04d2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6d497a0c-fb67-4cfc-9b3d-9c7707540945"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("903f2511-1e6c-4394-bbf7-b10c861ee87c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("979cdb72-b99c-4d19-b019-31cced190935"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9cafd476-b1c1-4a0c-b09f-96468949facd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a53cb171-f4bd-40ad-af4d-00eb1cacf8a2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b3289928-7736-40bb-bba9-7f25bcb19537"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b3fcb046-ae3c-4b13-bc89-70cfed9479ad"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cd93c1b0-2486-4fa2-93cf-41b1e06948ed"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e37e9bc0-aaaa-416f-b0a2-c79613e9fdc8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eb3afb6e-1a2d-4d39-9761-33c118bc2e73"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eecf2ca3-ba87-42ec-b1bd-570a9b98e709"));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Products",
                type: "character varying(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Orders",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Orders",
                type: "character varying(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Orders",
                type: "character varying(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Customers",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Customers",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "CategoryName",
                table: "Categories",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedDate", "Email", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("021b2992-64c1-4160-836f-36b0a6446dc2"), new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7050), "example1@mail.com", "Berke Öztürk", new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7050) },
                    { new Guid("02bbe1a6-b908-4f7f-8577-69601fa9dbf9"), new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7120), "example14@mail.com", "Deniz Zarshat", new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7120) },
                    { new Guid("5104002b-fc7b-4ff1-a992-8159aef78837"), new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7110), "example12@mail.com", "Barkın Özkaplan", new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7110) },
                    { new Guid("5c4f0c1c-f5e4-41a5-842c-72220ecec0fc"), new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7100), "example11@mail.com", "Ozan İmamhatipoğlu", new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7110) },
                    { new Guid("6b03d16b-c16a-4994-bd07-b2325542292c"), new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7070), "example6@mail.com", "Ahmet Mümtaz Taylan", new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7070) },
                    { new Guid("71b3b994-6efb-4dd2-a075-a1116a967d49"), new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7080), "example9@mail.com", "Mahsun Kırmızıgül", new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7080) },
                    { new Guid("7d24d476-08c9-4a0c-b063-8d4c720a9167"), new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7070), "example5@mail.com", "Atakan Yıldırım", new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7070) },
                    { new Guid("823b9562-6dd4-4875-a894-d760a9928c2b"), new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7080), "example8@mail.com", "Şahan Gökbakar", new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7080) },
                    { new Guid("9e95f67b-5093-4e7d-a40c-1bfba880a368"), new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7060), "example2@mail.com", "Doğa Su Türkileri", new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7060) },
                    { new Guid("b7037f28-11e5-437d-8eff-a2226cd19c2e"), new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7100), "example10@mail.com", "Erkin Karaçay", new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7100) },
                    { new Guid("b975bc43-fb3e-4e8a-8181-e1392f8a2aaf"), new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7110), "example13@mail.com", "Barış Onur Aydın", new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7110) },
                    { new Guid("bd104b34-10fe-495f-bda9-01aff45faa3d"), new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7060), "example3@mail.com", "Ervin Parlak", new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7060) },
                    { new Guid("db447099-d227-46e3-8ea5-6d0af8f87e2f"), new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7060), "example4@mail.com", "Gamze Naz Yıldırım", new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7060) },
                    { new Guid("defe0b94-726e-4095-a7eb-e9523bc3bebd"), new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7070), "example7@mail.com", "Cem Yılmaz", new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7080) }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "CreatedDate", "CustomerId", "Description", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("05ce36b4-859e-4467-860d-fb99ba0dc49b"), "456 Elm Avenue, Oakville, CA 94022", new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7190), new Guid("f0448773-a9f2-4820-9ceb-7d545af15b7e"), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7190) },
                    { new Guid("2f190b66-749c-48c6-b6b9-0bd31ef056be"), "789 Pine Lane, Rivertown, TX 75001", new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7220), new Guid("27302df3-ed18-4454-810f-86655a14da73"), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7220) },
                    { new Guid("481829c7-a28a-467b-8822-b5254a23b36e"), "1010 Birch Road, Forestville, WA 98001", new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7240), new Guid("08cd19c3-7f17-4d6e-9abd-d2dbe870e1a6"), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7240) },
                    { new Guid("571a7949-72a0-4d42-8b86-6d50eed9dcf2"), "5555 Redwood Street, Greenfield, AZ 85001", new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7230), new Guid("1f7aceb3-6109-43d9-a362-729b578006e8"), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7230) },
                    { new Guid("7c909f5a-4a31-44d2-b670-f5d5fa7faac7"), "4444 Aspen Court, Meadowbrook, OR 97001", new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7210), new Guid("57205986-1877-4445-975b-4ad086a7c1b0"), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7210) },
                    { new Guid("92f53599-543a-4d90-af8c-f48d9d7efa94"), "8888 Cypress Circle, Riverview, MI 48201", new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7250), new Guid("9aab7462-78af-4fea-b9dc-c2821cd47a6d"), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7250) },
                    { new Guid("94a2b707-d968-4a76-ba07-77d6bffcb673"), "7777 Poplar Path, Brookhaven, GA 30301", new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7230), new Guid("d6a5c7bb-6bfd-4417-8acb-7f9a03d5ac17"), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7230) },
                    { new Guid("957a1a2b-5130-432a-a77f-be335feb289d"), "2222 Oak Drive, Hillcrest, NY 10001", new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7190), new Guid("2012fe04-c7c6-4940-84f0-a1e0f543fe5e"), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7190) },
                    { new Guid("9dac4830-1c29-4d3f-bf1b-68936d70269a"), "10101 Juniper Avenue, Blue Ridge, NC 27501", new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7200), new Guid("a74daf87-beb2-4307-99a8-18d55717c3c8"), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7200) },
                    { new Guid("b1544082-ffbf-4423-b24f-41a796fa7530"), "9999 Spruce Place, Highland, UT 84003", new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7210), new Guid("282b3e41-363c-4f0f-87e4-87f5fc01db17"), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7210) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "Name", "Price", "Stock", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0f1d1e36-521f-4a1d-8819-07f70451e559"), new Guid("b16e1256-86af-4099-bafd-db06787f68fc"), new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7290), "A powerful gaming laptop with high-end graphics and fast processing speed. Ideal for gamers.", "RedwoodX Gaming Laptop", 1299.99, 30.0, new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7290) },
                    { new Guid("168a1ef2-b01a-43fd-8ad4-20b19e76e5ad"), new Guid("9d96387e-c8b1-4504-b803-632ec7be9f06"), new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7360), "A lightweight and durable camping tent that accommodates up to 4 people. Easy to set up.", "WillowLite Camping Tent", 199.99000000000001, 70.0, new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7360) },
                    { new Guid("17c49146-62ca-40c6-9f67-661dfbaba6b6"), new Guid("a291f8cf-43fe-4fd9-b126-21d08fa0b289"), new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7300), "A fitness tracker with heart rate monitoring, step counting, and sleep tracking. Waterproof design.", "PoplarPulse Fitness Tracker", 49.990000000000002, 220.0, new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7300) },
                    { new Guid("2bed43a5-fffd-4935-bba4-8342b23a4e46"), new Guid("ca55d5b5-9651-4f18-8ba5-6bd73bdcf163"), new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7310), "A non-slip yoga mat with extra cushioning for comfort. Perfect for yoga and pilates.", "CypressFlow Yoga Mat", 29.989999999999998, 500.0, new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7310) },
                    { new Guid("31b9ca67-1956-4da1-ad92-414203ac30cc"), new Guid("47112e0f-7a07-4803-8be3-cc521966860a"), new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7370), "A high-capacity power bank with fast charging technology. Compatible with all USB devices.", "RedwoodMax Power Bank", 39.990000000000002, 250.0, new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7370) },
                    { new Guid("3465eec2-4082-4981-a052-80e4c1787c84"), new Guid("fb35511e-fe7a-406a-b20a-b80c7c608bad"), new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7330), "A durable and flexible smartphone case that provides excellent protection. Compatible with most models.", "MapleFlex Smartphone Case", 19.989999999999998, 350.0, new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7330) },
                    { new Guid("386c2f54-ad3f-468a-8982-19a36e00d597"), new Guid("3dbc50d8-01ff-4504-9b5a-8806ddc1d688"), new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7270), "Lightweight and comfortable running shoes with breathable mesh and cushioned sole.", "OakHill Running Shoes", 89.989999999999995, 300.0, new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7270) },
                    { new Guid("422e433e-d817-474e-ba63-12e81608f4f6"), new Guid("4e023979-b606-4b6d-8e73-a33906604f7e"), new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7340), "A professional kitchen knife set with high-carbon stainless steel blades. Includes 6 knives and ablock.", "PineEdge Kitchen Knife Set", 89.989999999999995, 85.0, new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7340) },
                    { new Guid("4639e332-6d30-4d56-9049-bb6153d792a0"), new Guid("c248b181-00b9-4661-8018-40c379dd795a"), new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7360), "A programmable coffee maker with a built-in grinder and timer. Makes up to 12 cups of coffee.", "OakPure Coffee Maker", 129.99000000000001, 90.0, new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7360) },
                    { new Guid("51c74c43-5d3b-4b68-b5ad-57a24a68c62f"), new Guid("718bcaec-40dd-4743-9fe2-5a9668594482"), new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7300), "A smart home security camera with night vision and motion detection. Connects to your smartphone.", "FirNest Home Security Camera", 99.989999999999995, 100.0, new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7300) },
                    { new Guid("54437af2-8b29-4f17-90a2-abf477aed745"), new Guid("aa93bad0-3991-4a8a-854e-1e8c8eb41125"), new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7280), "A portable Bluetooth speaker with high-quality sound and long battery life. Perfectforoutdooractivities.", "WillowWave Bluetooth Speaker", 59.990000000000002, 250.0, new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7280) },
                    { new Guid("57b9e375-53c2-4df5-9986-24781db1b4ae"), new Guid("35fa0668-ac2b-4ff3-aaa4-f25eb8a36c37"), new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7270), "An ergonomic office chair with adjustable height and lumbar support. Ideal for long hours of work.", "BirchCraft Office Chair", 149.99000000000001, 150.0, new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7270) },
                    { new Guid("6eba8dda-ec0b-47a2-900f-9c14430e63c8"), new Guid("9e2d05a5-fc78-4537-88d6-dc94e6015f59"), new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7350), "High-quality wireless earbuds with noise cancellation and long battery life. Comes with a chargingcase.", "BirchSound Wireless Earbuds", 79.989999999999995, 300.0, new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7350) },
                    { new Guid("a1239caf-37e7-40d3-8d4a-08e400e92496"), new Guid("dd3a167f-f108-438a-9587-ad6c3504873d"), new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7320), "A high-performance drone with HD camera and long battery life. Ideal for aerial photography.", "SpruceSky Drone", 349.99000000000001, 60.0, new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7320) },
                    { new Guid("a3382b72-5452-44a2-990d-d060b4780ae9"), new Guid("e6a79807-08df-4a07-8fde-6be7373803b3"), new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7370), "A compact mini fridge with adjustable temperature settings. Perfect for dorm rooms and offices.", "AspenCool Mini Fridge", 149.99000000000001, 120.0, new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7370) },
                    { new Guid("aa64b996-e9f2-450b-b9cb-47706e857437"), new Guid("d695ba01-ae33-468e-8f33-63180b4d7dbe"), new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7290), "A stylish LED lamp with adjustable brightness and color temperature. Ideal for reading and working.", "AspenGlow LED Lamp", 39.990000000000002, 180.0, new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7290) },
                    { new Guid("b4b4534c-cc35-4e62-a496-397dd72d5ce1"), new Guid("fe5cf69b-555a-4cc7-a1cf-5b221de463df"), new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7340), "A contemporary table lamp with touch control and adjustable brightness. Perfect for any room.", "ElmGlow Table Lamp", 34.990000000000002, 140.0, new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7340) },
                    { new Guid("d7190fe0-03f4-4292-bfb3-9d3e790352de"), new Guid("d7c60025-1686-477a-94b3-14fbfd7ef26c"), new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7320), "An insulated water bottle that keeps drinks hot or cold for hours. Made from stainless steel.", "JuniperPure Water Bottle", 24.989999999999998, 400.0, new DateTime(2024, 7, 25, 11, 21, 8, 52, DateTimeKind.Utc).AddTicks(7320) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("021b2992-64c1-4160-836f-36b0a6446dc2"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("02bbe1a6-b908-4f7f-8577-69601fa9dbf9"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("5104002b-fc7b-4ff1-a992-8159aef78837"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("5c4f0c1c-f5e4-41a5-842c-72220ecec0fc"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("6b03d16b-c16a-4994-bd07-b2325542292c"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("71b3b994-6efb-4dd2-a075-a1116a967d49"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("7d24d476-08c9-4a0c-b063-8d4c720a9167"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("823b9562-6dd4-4875-a894-d760a9928c2b"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("9e95f67b-5093-4e7d-a40c-1bfba880a368"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("b7037f28-11e5-437d-8eff-a2226cd19c2e"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("b975bc43-fb3e-4e8a-8181-e1392f8a2aaf"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("bd104b34-10fe-495f-bda9-01aff45faa3d"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("db447099-d227-46e3-8ea5-6d0af8f87e2f"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("defe0b94-726e-4095-a7eb-e9523bc3bebd"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("05ce36b4-859e-4467-860d-fb99ba0dc49b"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("2f190b66-749c-48c6-b6b9-0bd31ef056be"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("481829c7-a28a-467b-8822-b5254a23b36e"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("571a7949-72a0-4d42-8b86-6d50eed9dcf2"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("7c909f5a-4a31-44d2-b670-f5d5fa7faac7"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("92f53599-543a-4d90-af8c-f48d9d7efa94"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("94a2b707-d968-4a76-ba07-77d6bffcb673"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("957a1a2b-5130-432a-a77f-be335feb289d"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("9dac4830-1c29-4d3f-bf1b-68936d70269a"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("b1544082-ffbf-4423-b24f-41a796fa7530"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0f1d1e36-521f-4a1d-8819-07f70451e559"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("168a1ef2-b01a-43fd-8ad4-20b19e76e5ad"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("17c49146-62ca-40c6-9f67-661dfbaba6b6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2bed43a5-fffd-4935-bba4-8342b23a4e46"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("31b9ca67-1956-4da1-ad92-414203ac30cc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3465eec2-4082-4981-a052-80e4c1787c84"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("386c2f54-ad3f-468a-8982-19a36e00d597"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("422e433e-d817-474e-ba63-12e81608f4f6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4639e332-6d30-4d56-9049-bb6153d792a0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("51c74c43-5d3b-4b68-b5ad-57a24a68c62f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("54437af2-8b29-4f17-90a2-abf477aed745"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("57b9e375-53c2-4df5-9986-24781db1b4ae"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6eba8dda-ec0b-47a2-900f-9c14430e63c8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a1239caf-37e7-40d3-8d4a-08e400e92496"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a3382b72-5452-44a2-990d-d060b4780ae9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aa64b996-e9f2-450b-b9cb-47706e857437"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b4b4534c-cc35-4e62-a496-397dd72d5ce1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d7190fe0-03f4-4292-bfb3-9d3e790352de"));

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Customers");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Products",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Orders",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Orders",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Orders",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Customers",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "CategoryName",
                table: "Categories",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("334b725c-c51a-4239-a97a-0247eafac600"), new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6610), "Ervin Parlak", new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6610) },
                    { new Guid("36581f97-a442-492d-bfe6-e6cc01a05b95"), new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6620), "Atakan Yıldırım", new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6620) },
                    { new Guid("40b70c62-0bd2-4f60-9375-170f899caddd"), new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6650), "Barış Onur Aydın", new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6650) },
                    { new Guid("426fab99-9c25-408d-9b59-5381ecfee7cb"), new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6610), "Gamze Naz Yıldırım", new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6610) },
                    { new Guid("4f70160b-e0fe-4f02-b367-2711e3ec09b3"), new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6640), "Ozan İmamhatipoğlu", new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6640) },
                    { new Guid("5d9ba5f9-05bf-47df-b155-65b0db94ac4c"), new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6630), "Şahan Gökbakar", new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6630) },
                    { new Guid("6f9c3387-32d1-4352-bb2b-9b55ee564339"), new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6600), "Berke Öztürk", new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6600) },
                    { new Guid("6ff2f372-516d-4acc-8018-c47baf771fc0"), new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6640), "Erkin Karaçay", new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6640) },
                    { new Guid("79922af9-58bd-440f-ba27-894ba58a9753"), new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6610), "Doğa Su Türkileri", new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6610) },
                    { new Guid("8a3ec824-4dfb-4578-a7ef-1d80b04f7f74"), new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6640), "Barkın Özkaplan", new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6640) },
                    { new Guid("9ba3d168-2636-4e91-a2ce-fac2d26b1c10"), new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6620), "Ahmet Mümtaz Taylan", new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6620) },
                    { new Guid("caa2cfdd-8102-43aa-876d-d05b82b99774"), new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6650), "Deniz Zarshat", new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6650) },
                    { new Guid("cca7f8b1-7918-48d8-ac84-4d5b4854c96d"), new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6620), "Cem Yılmaz", new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6620) },
                    { new Guid("f1e37b6d-1b56-4b73-b920-5671eabcd82a"), new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6630), "Mahsun Kırmızıgül", new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6630) }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "CreatedDate", "CustomerId", "Description", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("04b22a55-b9cf-43b3-8991-46fb1ac918f0"), "4444 Aspen Court, Meadowbrook, OR 97001", new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6750), new Guid("0a095e95-12bd-4794-b5fd-20a59c8ba256"), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6750) },
                    { new Guid("0d0ad0ed-fae3-4f11-a9db-5f7fa68f06b2"), "8888 Cypress Circle, Riverview, MI 48201", new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6790), new Guid("f675151a-9a75-49ef-948d-5372993821c2"), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6790) },
                    { new Guid("4067b7e8-641b-4975-95ff-edf6e7e70031"), "456 Elm Avenue, Oakville, CA 94022", new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6730), new Guid("7c7c1546-cc8b-47e7-8949-fa3105e037ec"), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6730) },
                    { new Guid("4437e6ba-bf29-4ed0-97d8-33b28ab907c4"), "9999 Spruce Place, Highland, UT 84003", new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6750), new Guid("d378f285-dd87-4644-beb5-ea6d65e0ad19"), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6750) },
                    { new Guid("6c178372-e5d1-4792-a54b-69d8f93cbb60"), "1010 Birch Road, Forestville, WA 98001", new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6780), new Guid("009d91c9-0094-4869-bece-e7e3800aad42"), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6780) },
                    { new Guid("7f3190a1-de27-4fd6-a871-8e3eaec439cd"), "789 Pine Lane, Rivertown, TX 75001", new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6760), new Guid("1c5cd972-d122-4840-b267-6d87b5f56218"), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6760) },
                    { new Guid("8e532579-afbf-44b8-b404-1a6cab29e62f"), "7777 Poplar Path, Brookhaven, GA 30301", new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6770), new Guid("b99a63a8-2e60-4381-9ca3-d8706daa41ef"), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6770) },
                    { new Guid("992fe19f-d6b7-4060-9702-c5cad5421d6f"), "10101 Juniper Avenue, Blue Ridge, NC 27501", new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6740), new Guid("e71aa97b-ad44-498f-9851-7724def242db"), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6740) },
                    { new Guid("cd17ad98-6b38-497a-9af8-d515fe668287"), "5555 Redwood Street, Greenfield, AZ 85001", new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6770), new Guid("f9c926fb-e83e-442c-8106-e779034b900e"), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6770) },
                    { new Guid("dfd7724a-440f-4528-8283-9afd5202db71"), "2222 Oak Drive, Hillcrest, NY 10001", new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6730), new Guid("e502231d-da5c-4599-b6d4-b48bee0005c4"), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6730) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "Name", "Price", "Stock", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0aa6804c-b34c-4160-a678-eee372f7f939"), new Guid("1cfa36c8-b2a9-4b21-a7aa-38a1e4a42b7a"), new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6820), "Lightweight and comfortable running shoes with breathable mesh and cushioned sole.", "OakHill Running Shoes", 89.989999999999995, 300.0, new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6820) },
                    { new Guid("2d4c69c8-ec2d-4db2-934a-f0c6631a9778"), new Guid("4d9f352c-fbdd-488d-a6f1-418182338be9"), new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6840), "A powerful gaming laptop with high-end graphics and fast processing speed. Ideal for gamers.", "RedwoodX Gaming Laptop", 1299.99, 30.0, new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6840) },
                    { new Guid("31c73a76-a11f-48de-8820-e9bb95c85aab"), new Guid("4d6d02da-6e75-4cd4-a1d0-ecfe1d3b63f5"), new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6900), "A programmable coffee maker with a built-in grinder and timer. Makes up to 12 cups of coffee.", "OakPure Coffee Maker", 129.99000000000001, 90.0, new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6900) },
                    { new Guid("3d169583-70cf-40ea-92ff-68e40259fc1b"), new Guid("d827aca4-a501-4ef2-a0a7-655ef8d0ba67"), new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6850), "A fitness tracker with heart rate monitoring, step counting, and sleep tracking. Waterproof design.", "PoplarPulse Fitness Tracker", 49.990000000000002, 220.0, new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6850) },
                    { new Guid("4ba932ff-e2b9-42ef-8891-6d45158ba08d"), new Guid("0c06de46-714c-46b5-8da6-23850c5ce244"), new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6860), "A high-performance drone with HD camera and long battery life. Ideal for aerial photography.", "SpruceSky Drone", 349.99000000000001, 60.0, new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6860) },
                    { new Guid("5e41c522-22b8-4066-9d3c-6c3ee0f6e91c"), new Guid("ea9d423b-f45b-438e-bac6-079eb85d7b27"), new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6810), "An ergonomic office chair with adjustable height and lumbar support. Ideal for long hours of work.", "BirchCraft Office Chair", 149.99000000000001, 150.0, new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6810) },
                    { new Guid("66d31bdc-e187-4d7a-a6a2-b5396e9f04d2"), new Guid("b4361ec9-79da-4dc5-94d4-db1075b57d21"), new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6870), "An insulated water bottle that keeps drinks hot or cold for hours. Made from stainless steel.", "JuniperPure Water Bottle", 24.989999999999998, 400.0, new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6870) },
                    { new Guid("6d497a0c-fb67-4cfc-9b3d-9c7707540945"), new Guid("1e95f668-d795-4947-8c3d-7379ddfcc67e"), new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6860), "A non-slip yoga mat with extra cushioning for comfort. Perfect for yoga and pilates.", "CypressFlow Yoga Mat", 29.989999999999998, 500.0, new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6860) },
                    { new Guid("903f2511-1e6c-4394-bbf7-b10c861ee87c"), new Guid("cbd450cc-ea30-4c1f-9548-6fb0508a0471"), new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6920), "A high-capacity power bank with fast charging technology. Compatible with all USB devices.", "RedwoodMax Power Bank", 39.990000000000002, 250.0, new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6920) },
                    { new Guid("979cdb72-b99c-4d19-b019-31cced190935"), new Guid("04289bbe-defc-49a0-8fe7-3e8be83b0240"), new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6830), "A stylish LED lamp with adjustable brightness and color temperature. Ideal for reading and working.", "AspenGlow LED Lamp", 39.990000000000002, 180.0, new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6830) },
                    { new Guid("9cafd476-b1c1-4a0c-b09f-96468949facd"), new Guid("0c47df89-a0c7-4326-ad44-d90ec45b0fb9"), new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6880), "A contemporary table lamp with touch control and adjustable brightness. Perfect for any room.", "ElmGlow Table Lamp", 34.990000000000002, 140.0, new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6880) },
                    { new Guid("a53cb171-f4bd-40ad-af4d-00eb1cacf8a2"), new Guid("81b4dac2-5df3-4132-bb5e-25267f575816"), new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6890), "High-quality wireless earbuds with noise cancellation and long battery life. Comes with a charging case.", "BirchSound Wireless Earbuds", 79.989999999999995, 300.0, new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6890) },
                    { new Guid("b3289928-7736-40bb-bba9-7f25bcb19537"), new Guid("587187cc-73b2-42ef-bc87-16f563bab558"), new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6880), "A durable and flexible smartphone case that provides excellent protection. Compatible with most models.", "MapleFlex Smartphone Case", 19.989999999999998, 350.0, new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6880) },
                    { new Guid("b3fcb046-ae3c-4b13-bc89-70cfed9479ad"), new Guid("4ab3de3e-7657-448f-af78-0f4653e9eb01"), new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6840), "A smart home security camera with night vision and motion detection. Connects to your smartphone.", "FirNest Home Security Camera", 99.989999999999995, 100.0, new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6840) },
                    { new Guid("cd93c1b0-2486-4fa2-93cf-41b1e06948ed"), new Guid("04148bca-6c84-4ddf-87b2-7fef4cf4b587"), new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6890), "A professional kitchen knife set with high-carbon stainless steel blades. Includes 6 knives and a block.", "PineEdge Kitchen Knife Set", 89.989999999999995, 85.0, new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6890) },
                    { new Guid("e37e9bc0-aaaa-416f-b0a2-c79613e9fdc8"), new Guid("14fdc4c5-f660-4385-9c6a-01f4e5941a56"), new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6910), "A compact mini fridge with adjustable temperature settings. Perfect for dorm rooms and offices.", "AspenCool Mini Fridge", 149.99000000000001, 120.0, new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6910) },
                    { new Guid("eb3afb6e-1a2d-4d39-9761-33c118bc2e73"), new Guid("ad411f20-5e23-4d33-9a30-3d7f7a647245"), new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6910), "A lightweight and durable camping tent that accommodates up to 4 people. Easy to set up.", "WillowLite Camping Tent", 199.99000000000001, 70.0, new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6910) },
                    { new Guid("eecf2ca3-ba87-42ec-b1bd-570a9b98e709"), new Guid("fd17bb46-828c-465d-b665-d6a2142f8d69"), new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6820), "A portable Bluetooth speaker with high-quality sound and long battery life. Perfect for outdooractivities.", "WillowWave Bluetooth Speaker", 59.990000000000002, 250.0, new DateTime(2024, 7, 24, 14, 48, 16, 401, DateTimeKind.Utc).AddTicks(6820) }
                });
        }
    }
}
