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
                    Qantity = table.Column<int>(type: "integer", nullable: false)
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
                    { new Guid("0364321b-8e6a-4ea8-b4a9-f853d229ec05"), "Хлеб и выпечка" },
                    { new Guid("14e3b792-74c6-4c5f-95b6-c2e18c9253d1"), "Овощи" },
                    { new Guid("584e279d-acaa-42d9-a316-d681172a8b7a"), "Фрукты" },
                    { new Guid("887bdaf2-2fdf-493a-8779-59d36c05ec77"), "Молочные продукты" },
                    { new Guid("9f2ca956-b0d9-493d-94cd-86aedd0c9e8f"), "Сладости" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryProductId", "ImageURL", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("0247fbd8-098a-4a98-8fe5-4a2c953b267b"), new Guid("9f2ca956-b0d9-493d-94cd-86aedd0c9e8f"), "/ImagesForCursach/Sweets/Snickers.png", "Шоколадный батончик", 50m },
                    { new Guid("0f5b4833-1f9f-4730-9048-ac106f7fdb1a"), new Guid("0364321b-8e6a-4ea8-b4a9-f853d229ec05"), "/ImagesForCursach/BreadAndPastries/BreadAndRollRaisin.png", "Булочка с изюмом", 40m },
                    { new Guid("26855f80-25f1-40b1-9d0b-a1e40b085b6d"), new Guid("887bdaf2-2fdf-493a-8779-59d36c05ec77"), "/ImagesForCursach/MilkProducts/Milk.png", "Молоко", 80m },
                    { new Guid("26f0cd6f-1f7e-49f1-8a0b-94d1ba03471d"), new Guid("0364321b-8e6a-4ea8-b4a9-f853d229ec05"), "/ImagesForCursach/BreadAndPastries/Baton.png", "Батон", 25m },
                    { new Guid("394497ab-9cdc-447e-ae73-dac010f3ba3f"), new Guid("9f2ca956-b0d9-493d-94cd-86aedd0c9e8f"), "/ImagesForCursach/Sweets/Marmalade.png", "Мармелад", 40m },
                    { new Guid("44d20ea0-ede1-47d5-8e3e-d8adc8e6d86a"), new Guid("9f2ca956-b0d9-493d-94cd-86aedd0c9e8f"), "/ImagesForCursach/Sweets/Candy.png", "Конфеты", 25m },
                    { new Guid("499002a8-69da-4c0c-ac48-7e28b00d7ce8"), new Guid("0364321b-8e6a-4ea8-b4a9-f853d229ec05"), "/ImagesForCursach/BreadAndPastries/Bread.png", "Хлеб белый", 35m },
                    { new Guid("695f7260-8124-4aa5-b90d-830c696b8810"), new Guid("584e279d-acaa-42d9-a316-d681172a8b7a"), "/ImagesForCursach/Fruits/Apples.png", "Яблоки", 80m },
                    { new Guid("6fe3639a-7d6e-46fb-bf59-818eb571f1ff"), new Guid("584e279d-acaa-42d9-a316-d681172a8b7a"), "/ImagesForCursach/Fruits/Oranges.png", "Апельсины", 60m },
                    { new Guid("82f7154a-b92e-4260-95dc-251b719bbc02"), new Guid("14e3b792-74c6-4c5f-95b6-c2e18c9253d1"), "/ImagesForCursach/Vegetabbles/Carrots.png", "Морковь", 50m },
                    { new Guid("85dd0fac-318c-4510-ae16-8d89c7456993"), new Guid("14e3b792-74c6-4c5f-95b6-c2e18c9253d1"), "/ImagesForCursach/Vegetabbles/Potatoes.png", "Картофель", 40m },
                    { new Guid("8a62fc24-1d1e-4fc4-b23a-89d8ed34bd80"), new Guid("0364321b-8e6a-4ea8-b4a9-f853d229ec05"), "/ImagesForCursach/BreadAndPastries/CheseCake.png", "Ватрушка", 50m },
                    { new Guid("9075ac9b-9e53-450c-aedb-56e1e81407b0"), new Guid("887bdaf2-2fdf-493a-8779-59d36c05ec77"), "/ImagesForCursach/MilkProducts/ButterMilk.png", "Кефир", 50m },
                    { new Guid("956e5135-227e-4298-8ba9-060efc96fd0f"), new Guid("14e3b792-74c6-4c5f-95b6-c2e18c9253d1"), "/ImagesForCursach/Vegetabbles/Onions.png", "Лук", 30m },
                    { new Guid("9fb80e12-82dc-449a-a3f4-48e4f0080298"), new Guid("584e279d-acaa-42d9-a316-d681172a8b7a"), "/ImagesForCursach/Fruits/Grapefruit.png", "Грейпфрут", 55m },
                    { new Guid("a876cf0b-6805-4a9e-a39b-18390e58e342"), new Guid("584e279d-acaa-42d9-a316-d681172a8b7a"), "/ImagesForCursach/Fruits/Pears.png", "Груши", 45m },
                    { new Guid("ac54bcfa-343e-4394-bdc8-d58d9e2ebb32"), new Guid("14e3b792-74c6-4c5f-95b6-c2e18c9253d1"), "/ImagesForCursach/Vegetabbles/Cucumbers.png", "Огурцы", 70m },
                    { new Guid("baaccf4c-09e3-4f64-a01b-9cbd301f2eeb"), new Guid("0364321b-8e6a-4ea8-b4a9-f853d229ec05"), "/ImagesForCursach/BreadAndPastries/AppleCake.png", "Пирог с яблоками", 120m },
                    { new Guid("ca394d54-8b6a-4764-b972-f5217745fc83"), new Guid("9f2ca956-b0d9-493d-94cd-86aedd0c9e8f"), "/ImagesForCursach/Sweets/Biscuits.png", "Печенье", 30m },
                    { new Guid("d87f243b-865c-41d1-adee-09616642f6c2"), new Guid("887bdaf2-2fdf-493a-8779-59d36c05ec77"), "/ImagesForCursach/MilkProducts/SourCream.png", "Сметана", 60m },
                    { new Guid("e1df5688-59f9-4a2e-b570-f2af89bbbe2c"), new Guid("14e3b792-74c6-4c5f-95b6-c2e18c9253d1"), "/ImagesForCursach/Vegetabbles/Tomatoes.png", "Помидоры", 65m },
                    { new Guid("e2e05228-f208-44af-8c57-c6549b8b31aa"), new Guid("9f2ca956-b0d9-493d-94cd-86aedd0c9e8f"), "/ImagesForCursach/Sweets/IceCream.png", "Мороженое", 100m },
                    { new Guid("e3d6f06c-fa2a-4455-b77c-b9b5bf35e847"), new Guid("887bdaf2-2fdf-493a-8779-59d36c05ec77"), "/ImagesForCursach/MilkProducts/Yoghurt.png", "Йогурт", 40m },
                    { new Guid("eec7a8eb-3b29-4248-8116-f9a1dcc71716"), new Guid("584e279d-acaa-42d9-a316-d681172a8b7a"), "/ImagesForCursach/Fruits/Banan.png", "Бананы", 70m }
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
