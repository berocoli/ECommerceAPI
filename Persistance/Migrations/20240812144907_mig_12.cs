using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistance.Migrations
{
    /// <inheritdoc />
    public partial class mig_12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Products",
                type: "character varying(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("1196bdca-692d-4f4b-bfa9-672d10586bc2"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("2076d73b-cbc8-4d67-a3a3-89965302e958"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("298f0f0f-2a46-40f4-8237-aa674dca05f6"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("3a5b71dc-d1d2-4009-bf32-1b19a3d2d0c0"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("46856dc4-5e85-49e2-bf63-8cfdbc9a3b05"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("69a14f72-f9fb-49b7-9d9f-2b3f774deb64"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("71facde0-d11c-457d-9ff8-730159a88341"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("934da2eb-501b-4014-8ffc-66a2789975c9"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("9da9d768-a430-42c4-9e8d-8dec26a32110"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("9f5ed5e9-886e-48bb-b26a-f6b80e0ec7e2"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("c400303e-5a12-49bb-9678-95ec0bde7f94"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("e217b370-03e0-4d4a-b4d2-4f01847a2f2b"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("f341dfea-2d4f-41aa-aefb-ca3e12110f81"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("fa6ecf53-00c2-44ce-a967-8e20952ac1a6"));

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

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Products",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(250)",
                oldMaxLength: 250);

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
    }
}
