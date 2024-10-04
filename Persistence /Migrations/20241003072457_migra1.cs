using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class migra1 : Migration
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
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Surname = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    Role = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
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
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    CartId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    OrderId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carts_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Carts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CartId = table.Column<Guid>(type: "uuid", nullable: false),
                    ProductId = table.Column<Guid>(type: "uuid", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItems_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreatedDate", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("30607da0-a589-4f3a-bed0-fdfdc86fa0a0"), "Books", new DateTime(2024, 10, 3, 7, 24, 57, 666, DateTimeKind.Utc).AddTicks(5670), new DateTime(2024, 10, 3, 7, 24, 57, 666, DateTimeKind.Utc).AddTicks(5670) },
                    { new Guid("bc056651-bf49-4cc8-88fc-9e5a654c70cf"), "Electronics", new DateTime(2024, 10, 3, 7, 24, 57, 666, DateTimeKind.Utc).AddTicks(5670), new DateTime(2024, 10, 3, 7, 24, 57, 666, DateTimeKind.Utc).AddTicks(5670) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "Email", "Name", "Password", "Role", "Surname", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("1bcbeb89-608a-41d6-b875-6a0d206713dd"), new DateTime(2024, 10, 3, 7, 24, 57, 660, DateTimeKind.Utc).AddTicks(4250), "dogasuturkileri@mail.com", "Doğa Su", "E/CBTOmLHEsC7jockEih9g==.FOtiYzSRUaSEjT6gDirIBYUde81zELaD+R+RFWrw2uo=", false, "Türkileri", new DateTime(2024, 10, 3, 7, 24, 57, 660, DateTimeKind.Utc).AddTicks(4250) },
                    { new Guid("c72d7b59-898e-466c-98ff-9ddfe5f21d75"), new DateTime(2024, 10, 3, 7, 24, 57, 654, DateTimeKind.Utc).AddTicks(2470), "berkeozturk@mail.com", "Berke", "MV3HwrWZU1xwlIdGz/aDfA==.bK1dScwjLoFs4rrZ9bV6we8ZM7Y+qJVqFdl4kyVRMXg=", true, "Öztürk", new DateTime(2024, 10, 3, 7, 24, 57, 654, DateTimeKind.Utc).AddTicks(2470) },
                    { new Guid("d049f157-ba7c-4ffc-ab16-a3aebaebb60d"), new DateTime(2024, 10, 3, 7, 24, 57, 666, DateTimeKind.Utc).AddTicks(5570), "serpinkaratay@mail.com", "Soupy Serpin", "/IaUhcgRyQ/taVuZomiL2A==.3ef9cWIIGj3rd+etkdGVR51CP0YG2vkzoh0dAYlK4hk=", false, "Karasay", new DateTime(2024, 10, 3, 7, 24, 57, 666, DateTimeKind.Utc).AddTicks(5570) }
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "CreatedDate", "OrderId", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { new Guid("d45e50b8-b840-4554-a99b-0029d7431587"), new DateTime(2024, 10, 3, 7, 24, 57, 666, DateTimeKind.Utc).AddTicks(5720), null, new DateTime(2024, 10, 3, 7, 24, 57, 666, DateTimeKind.Utc).AddTicks(5720), new Guid("1bcbeb89-608a-41d6-b875-6a0d206713dd") },
                    { new Guid("e94aaf6e-c5d5-4e7a-a9c9-bdb17f504012"), new DateTime(2024, 10, 3, 7, 24, 57, 666, DateTimeKind.Utc).AddTicks(5720), null, new DateTime(2024, 10, 3, 7, 24, 57, 666, DateTimeKind.Utc).AddTicks(5720), new Guid("c72d7b59-898e-466c-98ff-9ddfe5f21d75") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "CartId", "CreatedDate", "Description", "Status", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { new Guid("0deb4047-8394-4b6f-8d42-be92b3c27b25"), "456 Elm St", new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2024, 10, 3, 7, 24, 57, 666, DateTimeKind.Utc).AddTicks(5760), "Gift order", "Shipped", new DateTime(2024, 10, 3, 7, 24, 57, 666, DateTimeKind.Utc).AddTicks(5760), new Guid("1bcbeb89-608a-41d6-b875-6a0d206713dd") },
                    { new Guid("b727fc35-8024-4fec-b31d-4d9eb3a466ad"), "123 Main St", new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2024, 10, 3, 7, 24, 57, 666, DateTimeKind.Utc).AddTicks(5760), "Deliver ASAP", "Pending", new DateTime(2024, 10, 3, 7, 24, 57, 666, DateTimeKind.Utc).AddTicks(5760), new Guid("c72d7b59-898e-466c-98ff-9ddfe5f21d75") }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "ImageUrl", "Name", "Price", "Stock", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0a4ff980-cbd7-4a25-8e90-90f182a546dc"), new Guid("bc056651-bf49-4cc8-88fc-9e5a654c70cf"), new DateTime(2024, 10, 3, 7, 24, 57, 666, DateTimeKind.Utc).AddTicks(5690), "Latest smartphone model", "/images/smartphone.jpg", "Smartphone", 599.99000000000001, 100.0, new DateTime(2024, 10, 3, 7, 24, 57, 666, DateTimeKind.Utc).AddTicks(5690) },
                    { new Guid("0d4bb849-f64b-47fe-a6a6-3a626cfcdc9a"), new Guid("30607da0-a589-4f3a-bed0-fdfdc86fa0a0"), new DateTime(2024, 10, 3, 7, 24, 57, 666, DateTimeKind.Utc).AddTicks(5700), "Interesting novel", "/images/booka.jpg", "Book A", 19.989999999999998, 200.0, new DateTime(2024, 10, 3, 7, 24, 57, 666, DateTimeKind.Utc).AddTicks(5700) },
                    { new Guid("988bcece-9755-4a78-9a04-958d8c38ea60"), new Guid("bc056651-bf49-4cc8-88fc-9e5a654c70cf"), new DateTime(2024, 10, 3, 7, 24, 57, 666, DateTimeKind.Utc).AddTicks(5690), "High-performance laptop", "/images/laptop.jpg", "Laptop", 1099.99, 50.0, new DateTime(2024, 10, 3, 7, 24, 57, 666, DateTimeKind.Utc).AddTicks(5690) }
                });

            migrationBuilder.InsertData(
                table: "CartItems",
                columns: new[] { "Id", "CartId", "CreatedDate", "ProductId", "Quantity", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("db006314-8c62-4bfb-ab9c-cc2ce6af1988"), new Guid("d45e50b8-b840-4554-a99b-0029d7431587"), new DateTime(2024, 10, 3, 7, 24, 57, 666, DateTimeKind.Utc).AddTicks(5740), new Guid("0d4bb849-f64b-47fe-a6a6-3a626cfcdc9a"), 1, new DateTime(2024, 10, 3, 7, 24, 57, 666, DateTimeKind.Utc).AddTicks(5740) },
                    { new Guid("fa809200-614d-4c98-8719-df4ae70abf1a"), new Guid("e94aaf6e-c5d5-4e7a-a9c9-bdb17f504012"), new DateTime(2024, 10, 3, 7, 24, 57, 666, DateTimeKind.Utc).AddTicks(5730), new Guid("0a4ff980-cbd7-4a25-8e90-90f182a546dc"), 2, new DateTime(2024, 10, 3, 7, 24, 57, 666, DateTimeKind.Utc).AddTicks(5730) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_CartId",
                table: "CartItems",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ProductId",
                table: "CartItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_OrderId",
                table: "Carts",
                column: "OrderId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserId",
                table: "Carts",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
