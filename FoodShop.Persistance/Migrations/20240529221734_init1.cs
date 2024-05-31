using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodShop.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class init1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Login = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    Cash = table.Column<decimal>(type: "numeric", nullable: false),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoryProducts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryProducts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Wallets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    HolderName = table.Column<string>(type: "text", nullable: false),
                    Number = table.Column<string>(type: "text", nullable: false),
                    CVV = table.Column<string>(type: "text", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Amount = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wallets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    RoleId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BonusCards",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Account = table.Column<string>(type: "text", nullable: false),
                    Amount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BonusCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BonusCards_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    Payment = table.Column<int>(type: "integer", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ApplicationUserId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    CategoryProductId = table.Column<Guid>(type: "uuid", nullable: false),
                    ImageURL = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_CategoryProducts_CategoryProductId",
                        column: x => x.CategoryProductId,
                        principalTable: "CategoryProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OrderId = table.Column<Guid>(type: "uuid", nullable: false),
                    ProductId = table.Column<Guid>(type: "uuid", nullable: false),
                    Qantity = table.Column<int>(type: "integer", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sales_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sales_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CategoryProducts",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("47a71f1e-e386-404c-a38a-a0172124ebd8"), "Сладости" },
                    { new Guid("6368c3a6-371b-4e71-9368-259962da5dc0"), "Хлеб и выпечка" },
                    { new Guid("7ecc616c-f09b-44d4-83ab-c4d31e237eb5"), "Фрукты" },
                    { new Guid("97fba9e2-0ce4-4175-a135-f687287582b1"), "Овощи" },
                    { new Guid("f1de3e56-cee8-43f9-a90d-61e21feb262b"), "Молочные продукты" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryProductId", "ImageURL", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("03636c13-8afc-4f37-8886-62604495d1cd"), new Guid("97fba9e2-0ce4-4175-a135-f687287582b1"), "/ImagesForCursach/Vegetabbles/Onions.png", "Лук", 30m },
                    { new Guid("0f317567-48f5-4941-b15e-625a7bdee4a9"), new Guid("7ecc616c-f09b-44d4-83ab-c4d31e237eb5"), "/ImagesForCursach/Fruits/Pears.png", "Груши", 45m },
                    { new Guid("21fbae37-17ca-441e-b786-6701a7190483"), new Guid("6368c3a6-371b-4e71-9368-259962da5dc0"), "/ImagesForCursach/BreadAndPastries/Baton.png", "Батон", 25m },
                    { new Guid("2c4290e9-93a9-4514-83d9-60923e6e04d4"), new Guid("f1de3e56-cee8-43f9-a90d-61e21feb262b"), "/ImagesForCursach/MilkProducts/Yoghurt.png", "Йогурт", 40m },
                    { new Guid("3c90457d-29bc-4a5f-b88b-7f90a9ee3f78"), new Guid("47a71f1e-e386-404c-a38a-a0172124ebd8"), "/ImagesForCursach/Sweets/Candy.png", "Конфеты", 25m },
                    { new Guid("4009b958-37ad-4a30-9eed-3269465fae48"), new Guid("47a71f1e-e386-404c-a38a-a0172124ebd8"), "/ImagesForCursach/Sweets/IceCream.png", "Мороженое", 100m },
                    { new Guid("41260f90-ef91-41a2-9962-dd078f4fbb59"), new Guid("7ecc616c-f09b-44d4-83ab-c4d31e237eb5"), "/ImagesForCursach/Fruits/Grapefruit.png", "Грейпфрут", 55m },
                    { new Guid("450ad9c2-6677-4fd4-9fed-9297ef780d5a"), new Guid("97fba9e2-0ce4-4175-a135-f687287582b1"), "/ImagesForCursach/Vegetabbles/Potatoes.png", "Картофель", 40m },
                    { new Guid("477af63e-c818-4ead-92e2-57d9e6a3c745"), new Guid("47a71f1e-e386-404c-a38a-a0172124ebd8"), "/ImagesForCursach/Sweets/Snickers.png", "Шоколадный батончик", 50m },
                    { new Guid("478dbc57-d6d0-4926-a9cd-3860a190531a"), new Guid("47a71f1e-e386-404c-a38a-a0172124ebd8"), "/ImagesForCursach/Sweets/Marmalade.png", "Мармелад", 40m },
                    { new Guid("49a8f214-8ab2-42bb-bfc5-5de5037c4dc6"), new Guid("f1de3e56-cee8-43f9-a90d-61e21feb262b"), "/ImagesForCursach/MilkProducts/ButterMilk.png", "Кефир", 50m },
                    { new Guid("54a10746-4b97-4075-8104-f7d246359b72"), new Guid("47a71f1e-e386-404c-a38a-a0172124ebd8"), "/ImagesForCursach/Sweets/Biscuits.png", "Печенье", 30m },
                    { new Guid("730ec087-4bc8-45d7-b90f-ab15f0a9359a"), new Guid("7ecc616c-f09b-44d4-83ab-c4d31e237eb5"), "/ImagesForCursach/Fruits/Oranges.png", "Апельсины", 60m },
                    { new Guid("8998c2ef-861f-46d8-a688-70931c472308"), new Guid("6368c3a6-371b-4e71-9368-259962da5dc0"), "/ImagesForCursach/BreadAndPastries/BreadAndRollRaisin.png", "Булочка с изюмом", 40m },
                    { new Guid("947b61e4-8d2f-41e9-930b-978826396ee0"), new Guid("97fba9e2-0ce4-4175-a135-f687287582b1"), "/ImagesForCursach/Vegetabbles/Carrots.png", "Морковь", 50m },
                    { new Guid("a838585b-0cbe-42d2-8df6-17c6d0a8a651"), new Guid("6368c3a6-371b-4e71-9368-259962da5dc0"), "/ImagesForCursach/BreadAndPastries/AppleCake.png", "Пирог с яблоками", 120m },
                    { new Guid("ca019809-ca67-4424-9819-6295e8bf95a9"), new Guid("6368c3a6-371b-4e71-9368-259962da5dc0"), "/ImagesForCursach/BreadAndPastries/CheseCake.png", "Ватрушка", 50m },
                    { new Guid("cc6fdda7-72b7-4d9a-ab68-9054bccb4336"), new Guid("f1de3e56-cee8-43f9-a90d-61e21feb262b"), "/ImagesForCursach/MilkProducts/Milk.png", "Молоко", 80m },
                    { new Guid("d10bde03-c746-43fa-965a-2e46fb07f8dd"), new Guid("f1de3e56-cee8-43f9-a90d-61e21feb262b"), "/ImagesForCursach/MilkProducts/SourCream.png", "Сметана", 60m },
                    { new Guid("dec205b9-e8c6-4aca-9027-c107dd3829eb"), new Guid("7ecc616c-f09b-44d4-83ab-c4d31e237eb5"), "/ImagesForCursach/Fruits/Banan.png", "Бананы", 70m },
                    { new Guid("efe52f75-7640-4aea-b6fa-f07c9f6b01bc"), new Guid("97fba9e2-0ce4-4175-a135-f687287582b1"), "/ImagesForCursach/Vegetabbles/Cucumbers.png", "Огурцы", 70m },
                    { new Guid("fc1979ad-fd7a-4fda-abc0-4f8ac467f7f5"), new Guid("97fba9e2-0ce4-4175-a135-f687287582b1"), "/ImagesForCursach/Vegetabbles/Tomatoes.png", "Помидоры", 65m },
                    { new Guid("fc4e9267-7fd0-41a4-aed4-3b7a9974f1b8"), new Guid("6368c3a6-371b-4e71-9368-259962da5dc0"), "/ImagesForCursach/BreadAndPastries/Bread.png", "Хлеб белый", 35m },
                    { new Guid("fdd5502a-e06d-4408-88cf-100fa5b86ee1"), new Guid("7ecc616c-f09b-44d4-83ab-c4d31e237eb5"), "/ImagesForCursach/Fruits/Apples.png", "Яблоки", 80m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ApplicationUserId",
                table: "Orders",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Id",
                table: "Orders",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryProductId",
                table: "Products",
                column: "CategoryProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_Id",
                table: "Sales",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sales_OrderId",
                table: "Sales",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_ProductId",
                table: "Sales",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BonusCards");

            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "Wallets");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "CategoryProducts");
        }
    }
}
