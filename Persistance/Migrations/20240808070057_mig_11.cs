using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistance.Migrations
{
    /// <inheritdoc />
    public partial class mig_11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("1574c5a5-eaac-4627-a3a1-4f154d779280"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("17c157ea-ea01-4501-897b-08a762e1539d"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("2d1027eb-593b-438c-a0a5-dab66c3f5e27"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("41a7a8c4-fdcd-4266-adc4-a5f3915cc20b"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("764abf2f-a4d3-4e8e-98e3-f4e501bdae0c"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("92474f7d-70ee-430e-80fb-c4ab74c5ddbe"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("9de7b83c-0d07-47af-b98e-6884519b68d5"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("a44c91dd-e978-4b75-8efa-fea0135b3cd6"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("a7a8ac66-721f-437f-9ca2-ab91b017405a"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("a943810d-1ed5-4d6e-a72b-37288197de53"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("b864c69f-bb05-4af6-8830-de7c889ba2cd"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("cca027b5-5d27-406a-9d70-241285b6c021"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("d7f9084d-c1da-45ac-b8e0-d095f467305c"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("ec98ee00-c824-4666-aafa-b932e569203b"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("2b7174a8-e388-4584-bfdc-047249d80924"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("42134d94-1b79-459a-a269-59076cfc6d2f"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("6025fb7d-cb29-401a-86ab-bf74a21c64f8"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("60b56e23-2305-42ca-80c6-a0dc9fd04cad"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("68967530-a4cc-4dc9-9593-11b0c181664a"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("8030d00e-7304-498a-b4dc-9a6e7d0ae338"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("894bea55-364f-4dac-b0a2-09707f411eb4"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("8e32e065-8275-4652-a15c-c6d9ca4ea815"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("9c815b78-97bd-4040-aae6-4f63290ae46f"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e2ca0f14-5252-48ac-836c-cb000b0aaf60"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("08667153-bf9d-4915-8f84-001916476eeb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0fc2d043-0714-4a4d-ab96-e9b73a21e9e5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("154a678d-8b66-4467-90c9-9a6fe9a08971"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2dc5979e-2185-45ee-9adf-00b9daedfa00"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("39e167dd-00e9-42a1-bc0a-cf4f2c0b4c6d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3a0320f0-a2ce-4580-8d36-b136f0005d8c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("657f3107-e583-4bf5-a19c-cec337d83f3c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("71874edc-e11b-4c3f-8299-a81f91c40cc2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("810d90ef-56f5-48ea-8682-d38b9fcc61e8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("872d3421-5038-49e1-8a15-008068ea46fa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8b92dfd3-d7b7-40aa-a6b4-7b1bd1597719"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8f1509cd-e282-4b0f-ab82-4b457ea90ebc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a5d7bf2a-c07a-4f11-93fc-f20556bd930e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a6d17b8b-5c6a-4482-9a57-6a457782c0a5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bb1d520a-fb43-4ca6-9718-49745d4222e6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c9683cb5-a495-482c-bc28-9daefabc5c63"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dcd2c947-6079-4529-b92b-0da24e40f26e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f5ce7751-8e6b-42e8-b2c3-29ff1a3a36a7"));

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Products",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedDate", "Email", "Name", "Password", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("09007d21-4ce9-4c44-8a0e-f6642f1ddf07"), new DateTime(2024, 8, 8, 7, 0, 57, 586, DateTimeKind.Utc).AddTicks(5030), "example8@mail.com", "Şahan Gökbakar", "nQ6UFu1knkl2UZU4jqdKIg==.sGR6vG4KzX838Q1HU5t3hKiQ83hzqR24gHsbIzZCTMs=", new DateTime(2024, 8, 8, 7, 0, 57, 586, DateTimeKind.Utc).AddTicks(5030) },
                    { new Guid("12aa0cc7-ace9-4256-b61f-0fc0d3da8804"), new DateTime(2024, 8, 8, 7, 0, 57, 624, DateTimeKind.Utc).AddTicks(3410), "example14@mail.com", "Deniz Zarshat", "GEDKNly0OeRASueq+PcsAw==.XYjFJRt6xoVwHogawM/GiVAvky7rxOoGzN5mgU1qpUU=", new DateTime(2024, 8, 8, 7, 0, 57, 624, DateTimeKind.Utc).AddTicks(3410) },
                    { new Guid("1ffd9cf6-89ce-419f-be72-44dce53d137f"), new DateTime(2024, 8, 8, 7, 0, 57, 541, DateTimeKind.Utc).AddTicks(550), "example1@mail.com", "Berke Öztürk", "woK+ML+2b3uyZYta9Pf6gA==.p9/lHnjuOYypbJvPVwzAVYpz8tm1ORcfwq0PNXMOMcQ=", new DateTime(2024, 8, 8, 7, 0, 57, 541, DateTimeKind.Utc).AddTicks(550) },
                    { new Guid("2926ba09-1b5d-4bee-b708-83e91344f308"), new DateTime(2024, 8, 8, 7, 0, 57, 580, DateTimeKind.Utc).AddTicks(3060), "example7@mail.com", "Cem Yılmaz", "PHZH81DbNiZRtinm+xCHTQ==.lyP5mKmdS6UiaR1HEoK4E8NciSf/5GC2s03dx4Z/srk=", new DateTime(2024, 8, 8, 7, 0, 57, 580, DateTimeKind.Utc).AddTicks(3060) },
                    { new Guid("2d4cf6c9-e0b1-445f-8edb-df89d204ba37"), new DateTime(2024, 8, 8, 7, 0, 57, 567, DateTimeKind.Utc).AddTicks(9200), "example5@mail.com", "Atakan Yıldırım", "QjGxdPcXnVmvAQ75VhnOYQ==.13USZ2rbd8R9DM4h0UVNvDt3FCpHEO3T4hxlG/538Lk=", new DateTime(2024, 8, 8, 7, 0, 57, 567, DateTimeKind.Utc).AddTicks(9200) },
                    { new Guid("354881a7-457e-49a7-948b-04b55dfd0a2e"), new DateTime(2024, 8, 8, 7, 0, 57, 611, DateTimeKind.Utc).AddTicks(9480), "example12@mail.com", "Barkın Özkaplan", "DGnDT3PLk5H6QT++pisXNQ==.SwKOEYJnW3Wh405IAPEnXRRZXB3hGEOCF93dcLCocgU=", new DateTime(2024, 8, 8, 7, 0, 57, 611, DateTimeKind.Utc).AddTicks(9480) },
                    { new Guid("4b968ef8-e190-4865-bd2e-f062c31e0e8c"), new DateTime(2024, 8, 8, 7, 0, 57, 560, DateTimeKind.Utc).AddTicks(520), "example4@mail.com", "Gamze Naz Yıldırım", "tmspOXBzeqq+Bach50J/Ag==.P3Ud9mpSSS/7PiJKYMMqNDCahYzH0EUITZZPCB6PdK8=", new DateTime(2024, 8, 8, 7, 0, 57, 560, DateTimeKind.Utc).AddTicks(520) },
                    { new Guid("4d38e1b5-93a0-43d3-8a95-22964794f76d"), new DateTime(2024, 8, 8, 7, 0, 57, 553, DateTimeKind.Utc).AddTicks(6020), "example3@mail.com", "Ervin Parlak", "M1fbjXLJnq9MDyQBfJbHXQ==.MIlC1hdCK0SVyRfooW2K6wwt44dfN7WLwddgc1p157I=", new DateTime(2024, 8, 8, 7, 0, 57, 553, DateTimeKind.Utc).AddTicks(6020) },
                    { new Guid("72e0165d-168a-433d-ac1a-e9b4942d4ab5"), new DateTime(2024, 8, 8, 7, 0, 57, 598, DateTimeKind.Utc).AddTicks(9230), "example10@mail.com", "Erkin Karaçay", "3nnVCneEoxf5r8eGm8I+6Q==.2KjpI/uBhuHQlVPAa36PRkittXYribw3RBy344aMlPs=", new DateTime(2024, 8, 8, 7, 0, 57, 598, DateTimeKind.Utc).AddTicks(9230) },
                    { new Guid("7d0acf1a-1d19-4eb9-a069-11e78996e08a"), new DateTime(2024, 8, 8, 7, 0, 57, 605, DateTimeKind.Utc).AddTicks(1460), "example11@mail.com", "Ozan İmamhatipoğlu", "u3XPdJf6vIUh7hEfq9WN2w==.au9gSrmoGc9rX4eSitzBXEkCUanY0Y1doPUJzxshT+w=", new DateTime(2024, 8, 8, 7, 0, 57, 605, DateTimeKind.Utc).AddTicks(1460) },
                    { new Guid("8b7eb17f-c554-47f3-9fba-a0e09da08e8d"), new DateTime(2024, 8, 8, 7, 0, 57, 547, DateTimeKind.Utc).AddTicks(3370), "example2@mail.com", "Doğa Su Türkileri", "4n+4W0ea736QZFv7VPVdbw==.f0u7YCD0Wmxcr0KzU9hMgajF8JRMC/5Z7r3WmyvwqWQ=", new DateTime(2024, 8, 8, 7, 0, 57, 547, DateTimeKind.Utc).AddTicks(3370) },
                    { new Guid("a55002cb-c644-49f0-9d30-1e8a0b32f76f"), new DateTime(2024, 8, 8, 7, 0, 57, 574, DateTimeKind.Utc).AddTicks(1230), "example6@mail.com", "Ahmet Mümtaz Taylan", "41KTtxcZWasjsIRm1XMuOQ==.gHF3bgTw/4VLEqPLsb51U0LqjQvILj5VC1Ofj7zp7bA=", new DateTime(2024, 8, 8, 7, 0, 57, 574, DateTimeKind.Utc).AddTicks(1230) },
                    { new Guid("c9569b13-f5b9-4125-8113-da1414764c82"), new DateTime(2024, 8, 8, 7, 0, 57, 592, DateTimeKind.Utc).AddTicks(7330), "example9@mail.com", "Mahsun Kırmızıgül", "oQ5BFVdNEQMbYyMkT/QR5g==.bJcaJR5OxcMj1Rsmv5SutJPpgZh+b1y8nzvKN+GZbxw=", new DateTime(2024, 8, 8, 7, 0, 57, 592, DateTimeKind.Utc).AddTicks(7330) },
                    { new Guid("e3aa92d3-30b0-48ef-b949-4d617fbceb84"), new DateTime(2024, 8, 8, 7, 0, 57, 618, DateTimeKind.Utc).AddTicks(1570), "example13@mail.com", "Barış Onur Aydın", "xVA4UWJK0Sb4XweKanzMZg==.bHtof3o3E7yFK5jP/3XE7LteFxs3cLUUYwXnvgfm5jE=", new DateTime(2024, 8, 8, 7, 0, 57, 618, DateTimeKind.Utc).AddTicks(1570) }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "CreatedDate", "CustomerId", "Description", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0635d9a2-318e-405a-a3c9-6473f9d820be"), "9999 Spruce Place, Highland, UT 84003", new DateTime(2024, 8, 8, 7, 0, 57, 624, DateTimeKind.Utc).AddTicks(3630), new Guid("a851ed18-368c-43ed-8f1d-4435f87d40d4"), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 8, 8, 7, 0, 57, 624, DateTimeKind.Utc).AddTicks(3630) },
                    { new Guid("15917048-091f-4edf-9687-b96fce3a3826"), "1010 Birch Road, Forestville, WA 98001", new DateTime(2024, 8, 8, 7, 0, 57, 624, DateTimeKind.Utc).AddTicks(3660), new Guid("15fb1e70-d32d-4dab-9be7-fe6e70ecea74"), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 8, 8, 7, 0, 57, 624, DateTimeKind.Utc).AddTicks(3660) },
                    { new Guid("1c218c83-f310-412a-9cf2-6d4fc868ab99"), "7777 Poplar Path, Brookhaven, GA 30301", new DateTime(2024, 8, 8, 7, 0, 57, 624, DateTimeKind.Utc).AddTicks(3650), new Guid("b47a7b71-1e33-4cb9-8fb6-8b4016b26d69"), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 8, 8, 7, 0, 57, 624, DateTimeKind.Utc).AddTicks(3650) },
                    { new Guid("1edaae63-5714-4333-b43f-f7a706bd4912"), "4444 Aspen Court, Meadowbrook, OR 97001", new DateTime(2024, 8, 8, 7, 0, 57, 624, DateTimeKind.Utc).AddTicks(3630), new Guid("98a562bd-1060-474c-b4ca-89b8d7e8bb88"), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 8, 8, 7, 0, 57, 624, DateTimeKind.Utc).AddTicks(3630) },
                    { new Guid("1f120e32-93be-43a4-bed3-85bd4d5e794e"), "10101 Juniper Avenue, Blue Ridge, NC 27501", new DateTime(2024, 8, 8, 7, 0, 57, 624, DateTimeKind.Utc).AddTicks(3620), new Guid("9a6c3b1e-0348-4ac3-8f56-156e8d07b3ba"), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 8, 8, 7, 0, 57, 624, DateTimeKind.Utc).AddTicks(3620) },
                    { new Guid("21e0487d-28a3-4107-901f-959303d6f62b"), "5555 Redwood Street, Greenfield, AZ 85001", new DateTime(2024, 8, 8, 7, 0, 57, 624, DateTimeKind.Utc).AddTicks(3640), new Guid("a2833b3f-e84e-4188-933d-d88f3536e36b"), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 8, 8, 7, 0, 57, 624, DateTimeKind.Utc).AddTicks(3640) },
                    { new Guid("23532314-6950-413e-83ab-63111571dba6"), "8888 Cypress Circle, Riverview, MI 48201", new DateTime(2024, 8, 8, 7, 0, 57, 624, DateTimeKind.Utc).AddTicks(3660), new Guid("b8abc414-8d5f-476b-ae77-e732f3f3f479"), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 8, 8, 7, 0, 57, 624, DateTimeKind.Utc).AddTicks(3660) },
                    { new Guid("5749a3c2-3dbc-4319-8671-45a1df429d77"), "789 Pine Lane, Rivertown, TX 75001", new DateTime(2024, 8, 8, 7, 0, 57, 624, DateTimeKind.Utc).AddTicks(3640), new Guid("9e8c11d5-0018-462c-b7be-0710ea96eb67"), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 8, 8, 7, 0, 57, 624, DateTimeKind.Utc).AddTicks(3640) },
                    { new Guid("6cec4602-dce1-4079-b9d5-b7da77c68242"), "456 Elm Avenue, Oakville, CA 94022", new DateTime(2024, 8, 8, 7, 0, 57, 624, DateTimeKind.Utc).AddTicks(3610), new Guid("4c9049e9-1480-463b-bf3e-ab7e53608a39"), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 8, 8, 7, 0, 57, 624, DateTimeKind.Utc).AddTicks(3610) },
                    { new Guid("d5ce8df4-90ee-493f-b562-be427988c984"), "2222 Oak Drive, Hillcrest, NY 10001", new DateTime(2024, 8, 8, 7, 0, 57, 624, DateTimeKind.Utc).AddTicks(3610), new Guid("961803ef-8dc7-4960-adb9-02ffbfb8bd6f"), " Please leave the package at the front porch if no one is home.", "Pending", new DateTime(2024, 8, 8, 7, 0, 57, 624, DateTimeKind.Utc).AddTicks(3610) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "ImageUrl", "Name", "Price", "Stock", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("186830b2-3e6e-48b6-89fd-8465600c6ed4"), new Guid("648c5326-81f2-4f1f-9f56-07628534b5ef"), new DateTime(2024, 8, 8, 7, 0, 57, 624, DateTimeKind.Utc).AddTicks(3760), "A durable and flexible smartphone case that provides excellent protection. Compatible with most models.", " ", "MapleFlex Smartphone Case", 19.989999999999998, 350.0, new DateTime(2024, 8, 8, 7, 0, 57, 624, DateTimeKind.Utc).AddTicks(3760) },
                    { new Guid("1d08d102-e977-4a6e-b666-49c8bee0c4cd"), new Guid("eafa0309-32a7-4ee9-9ae8-4e2daa841a2e"), new DateTime(2024, 8, 8, 7, 0, 57, 624, DateTimeKind.Utc).AddTicks(3700), "Lightweight and comfortable running shoes with breathable mesh and cushioned sole.", " ", "OakHill Running Shoes", 89.989999999999995, 300.0, new DateTime(2024, 8, 8, 7, 0, 57, 624, DateTimeKind.Utc).AddTicks(3700) },
                    { new Guid("1eda4e77-0816-4ed6-8146-2669cd5fd785"), new Guid("bfb5bcd8-feb0-4e12-b938-532ecd251143"), new DateTime(2024, 8, 8, 7, 0, 57, 624, DateTimeKind.Utc).AddTicks(3750), "An insulated water bottle that keeps drinks hot or cold for hours. Made from stainless steel.", " ", "JuniperPure Water Bottle", 24.989999999999998, 400.0, new DateTime(2024, 8, 8, 7, 0, 57, 624, DateTimeKind.Utc).AddTicks(3750) },
                    { new Guid("34e53043-848b-4b1f-bc26-998c62c8cfbd"), new Guid("b3bed20c-04b9-45f4-9177-7fce46437b05"), new DateTime(2024, 8, 8, 7, 0, 57, 624, DateTimeKind.Utc).AddTicks(3720), "A smart home security camera with night vision and motion detection. Connects to your smartphone.", " ", "FirNest Home Security Camera", 99.989999999999995, 100.0, new DateTime(2024, 8, 8, 7, 0, 57, 624, DateTimeKind.Utc).AddTicks(3720) },
                    { new Guid("4b534b30-602a-4b99-8901-36583a6f0d07"), new Guid("8ea5171f-3753-4bd9-92b3-a3148793e0e0"), new DateTime(2024, 8, 8, 7, 0, 57, 624, DateTimeKind.Utc).AddTicks(3780), "A programmable coffee maker with a built-in grinder and timer. Makes up to 12 cups of coffee.", " ", "OakPure Coffee Maker", 129.99000000000001, 90.0, new DateTime(2024, 8, 8, 7, 0, 57, 624, DateTimeKind.Utc).AddTicks(3780) },
                    { new Guid("6824d5df-77f4-4bda-9ed1-fd818b86886e"), new Guid("b2016d8b-deba-4d21-af28-1768056bc280"), new DateTime(2024, 8, 8, 7, 0, 57, 624, DateTimeKind.Utc).AddTicks(3720), "A powerful gaming laptop with high-end graphics and fast processing speed. Ideal for gamers.", " ", "RedwoodX Gaming Laptop", 1299.99, 30.0, new DateTime(2024, 8, 8, 7, 0, 57, 624, DateTimeKind.Utc).AddTicks(3720) },
                    { new Guid("774ed65c-0a1e-4f00-a5f0-2b62751a69ae"), new Guid("829e518a-7da7-4247-88a4-93923d61cf11"), new DateTime(2024, 8, 8, 7, 0, 57, 624, DateTimeKind.Utc).AddTicks(3740), "A high-performance drone with HD camera and long battery life. Ideal for aerial photography.", " ", "SpruceSky Drone", 349.99000000000001, 60.0, new DateTime(2024, 8, 8, 7, 0, 57, 624, DateTimeKind.Utc).AddTicks(3740) },
                    { new Guid("8de97c76-c468-445c-96be-4603100724b0"), new Guid("bada52ef-8e9f-41be-8f5c-12e32bd4e316"), new DateTime(2024, 8, 8, 7, 0, 57, 624, DateTimeKind.Utc).AddTicks(3780), "High-quality wireless earbuds with noise cancellation and long battery life. Comes with a chargingcase.", " ", "BirchSound Wireless Earbuds", 79.989999999999995, 300.0, new DateTime(2024, 8, 8, 7, 0, 57, 624, DateTimeKind.Utc).AddTicks(3780) },
                    { new Guid("94c0762e-b55e-4ad5-ac80-2c3c241fc4f5"), new Guid("0df97d39-0cf6-4b25-b38e-1cfb5f741562"), new DateTime(2024, 8, 8, 7, 0, 57, 624, DateTimeKind.Utc).AddTicks(3790), "A lightweight and durable camping tent that accommodates up to 4 people. Easy to set up.", " ", "WillowLite Camping Tent", 199.99000000000001, 70.0, new DateTime(2024, 8, 8, 7, 0, 57, 624, DateTimeKind.Utc).AddTicks(3790) },
                    { new Guid("9d58f56c-6c65-4d66-9d9a-9c3e667f8cee"), new Guid("1426a39b-4c29-4b80-a24c-8f200bd91854"), new DateTime(2024, 8, 8, 7, 0, 57, 624, DateTimeKind.Utc).AddTicks(3800), "A high-capacity power bank with fast charging technology. Compatible with all USB devices.", " ", "RedwoodMax Power Bank", 39.990000000000002, 250.0, new DateTime(2024, 8, 8, 7, 0, 57, 624, DateTimeKind.Utc).AddTicks(3800) },
                    { new Guid("b0ff7b0f-93b0-496b-b935-075780d4e74c"), new Guid("5f94bc83-45f1-4567-83b7-4065de3cf765"), new DateTime(2024, 8, 8, 7, 0, 57, 624, DateTimeKind.Utc).AddTicks(3730), "A fitness tracker with heart rate monitoring, step counting, and sleep tracking. Waterproof design.", " ", "PoplarPulse Fitness Tracker", 49.990000000000002, 220.0, new DateTime(2024, 8, 8, 7, 0, 57, 624, DateTimeKind.Utc).AddTicks(3730) },
                    { new Guid("b268bf8c-e92b-4516-bfe3-edb330344867"), new Guid("20ea8e05-3177-4dc5-988a-287d1ecc829a"), new DateTime(2024, 8, 8, 7, 0, 57, 624, DateTimeKind.Utc).AddTicks(3740), "A non-slip yoga mat with extra cushioning for comfort. Perfect for yoga and pilates.", " ", "CypressFlow Yoga Mat", 29.989999999999998, 500.0, new DateTime(2024, 8, 8, 7, 0, 57, 624, DateTimeKind.Utc).AddTicks(3740) },
                    { new Guid("b8a930f9-2477-4210-9024-e5785f025c5d"), new Guid("f81caba5-b1a0-415a-a8cf-f5259b497427"), new DateTime(2024, 8, 8, 7, 0, 57, 624, DateTimeKind.Utc).AddTicks(3690), "An ergonomic office chair with adjustable height and lumbar support. Ideal for long hours of work.", " ", "BirchCraft Office Chair", 149.99000000000001, 150.0, new DateTime(2024, 8, 8, 7, 0, 57, 624, DateTimeKind.Utc).AddTicks(3690) },
                    { new Guid("bfaf4d91-9c6b-4e04-8de2-04cbdc569e2c"), new Guid("9cd99a87-5eb8-447a-8736-18bfab250072"), new DateTime(2024, 8, 8, 7, 0, 57, 624, DateTimeKind.Utc).AddTicks(3760), "A contemporary table lamp with touch control and adjustable brightness. Perfect for any room.", " ", "ElmGlow Table Lamp", 34.990000000000002, 140.0, new DateTime(2024, 8, 8, 7, 0, 57, 624, DateTimeKind.Utc).AddTicks(3760) },
                    { new Guid("c874fab0-9158-4563-8233-779ff5074e4c"), new Guid("c173f6eb-43d8-4e49-a30f-92b51e74522c"), new DateTime(2024, 8, 8, 7, 0, 57, 624, DateTimeKind.Utc).AddTicks(3710), "A stylish LED lamp with adjustable brightness and color temperature. Ideal for reading and working.", " ", "AspenGlow LED Lamp", 39.990000000000002, 180.0, new DateTime(2024, 8, 8, 7, 0, 57, 624, DateTimeKind.Utc).AddTicks(3710) },
                    { new Guid("d57ef050-9d46-4265-992f-94b3080ab1fd"), new Guid("20162b14-3683-43de-bac7-b1f8771cfe5d"), new DateTime(2024, 8, 8, 7, 0, 57, 624, DateTimeKind.Utc).AddTicks(3710), "A portable Bluetooth speaker with high-quality sound and long battery life. Perfectforoutdooractivities.", " ", "WillowWave Bluetooth Speaker", 59.990000000000002, 250.0, new DateTime(2024, 8, 8, 7, 0, 57, 624, DateTimeKind.Utc).AddTicks(3710) },
                    { new Guid("e1bfcb2f-007d-42da-a9b4-e8c49bebf50a"), new Guid("5cfff487-8cc8-4324-acc1-94b92c07145c"), new DateTime(2024, 8, 8, 7, 0, 57, 624, DateTimeKind.Utc).AddTicks(3790), "A compact mini fridge with adjustable temperature settings. Perfect for dorm rooms and offices.", " ", "AspenCool Mini Fridge", 149.99000000000001, 120.0, new DateTime(2024, 8, 8, 7, 0, 57, 624, DateTimeKind.Utc).AddTicks(3790) },
                    { new Guid("e6f31bec-c780-4e8b-b198-b2906e67fd1f"), new Guid("ea911285-12e4-4ffa-8467-9c301b492b3f"), new DateTime(2024, 8, 8, 7, 0, 57, 624, DateTimeKind.Utc).AddTicks(3770), "A professional kitchen knife set with high-carbon stainless steel blades. Includes 6 knives and ablock.", " ", "PineEdge Kitchen Knife Set", 89.989999999999995, 85.0, new DateTime(2024, 8, 8, 7, 0, 57, 624, DateTimeKind.Utc).AddTicks(3770) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("09007d21-4ce9-4c44-8a0e-f6642f1ddf07"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("12aa0cc7-ace9-4256-b61f-0fc0d3da8804"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("1ffd9cf6-89ce-419f-be72-44dce53d137f"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("2926ba09-1b5d-4bee-b708-83e91344f308"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("2d4cf6c9-e0b1-445f-8edb-df89d204ba37"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("354881a7-457e-49a7-948b-04b55dfd0a2e"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("4b968ef8-e190-4865-bd2e-f062c31e0e8c"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("4d38e1b5-93a0-43d3-8a95-22964794f76d"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("72e0165d-168a-433d-ac1a-e9b4942d4ab5"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("7d0acf1a-1d19-4eb9-a069-11e78996e08a"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("8b7eb17f-c554-47f3-9fba-a0e09da08e8d"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("a55002cb-c644-49f0-9d30-1e8a0b32f76f"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("c9569b13-f5b9-4125-8113-da1414764c82"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("e3aa92d3-30b0-48ef-b949-4d617fbceb84"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("0635d9a2-318e-405a-a3c9-6473f9d820be"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("15917048-091f-4edf-9687-b96fce3a3826"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("1c218c83-f310-412a-9cf2-6d4fc868ab99"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("1edaae63-5714-4333-b43f-f7a706bd4912"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("1f120e32-93be-43a4-bed3-85bd4d5e794e"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("21e0487d-28a3-4107-901f-959303d6f62b"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("23532314-6950-413e-83ab-63111571dba6"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("5749a3c2-3dbc-4319-8671-45a1df429d77"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("6cec4602-dce1-4079-b9d5-b7da77c68242"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("d5ce8df4-90ee-493f-b562-be427988c984"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("186830b2-3e6e-48b6-89fd-8465600c6ed4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1d08d102-e977-4a6e-b666-49c8bee0c4cd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1eda4e77-0816-4ed6-8146-2669cd5fd785"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("34e53043-848b-4b1f-bc26-998c62c8cfbd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4b534b30-602a-4b99-8901-36583a6f0d07"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6824d5df-77f4-4bda-9ed1-fd818b86886e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("774ed65c-0a1e-4f00-a5f0-2b62751a69ae"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8de97c76-c468-445c-96be-4603100724b0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("94c0762e-b55e-4ad5-ac80-2c3c241fc4f5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9d58f56c-6c65-4d66-9d9a-9c3e667f8cee"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b0ff7b0f-93b0-496b-b935-075780d4e74c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b268bf8c-e92b-4516-bfe3-edb330344867"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b8a930f9-2477-4210-9024-e5785f025c5d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bfaf4d91-9c6b-4e04-8de2-04cbdc569e2c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c874fab0-9158-4563-8233-779ff5074e4c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d57ef050-9d46-4265-992f-94b3080ab1fd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e1bfcb2f-007d-42da-a9b4-e8c49bebf50a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e6f31bec-c780-4e8b-b198-b2906e67fd1f"));

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Products");

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
    }
}
