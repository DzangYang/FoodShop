using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodShop.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_ApplicationUserId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_ApplicationUserId",
                table: "Orders");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("03636c13-8afc-4f37-8886-62604495d1cd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0f317567-48f5-4941-b15e-625a7bdee4a9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("21fbae37-17ca-441e-b786-6701a7190483"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2c4290e9-93a9-4514-83d9-60923e6e04d4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3c90457d-29bc-4a5f-b88b-7f90a9ee3f78"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4009b958-37ad-4a30-9eed-3269465fae48"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("41260f90-ef91-41a2-9962-dd078f4fbb59"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("450ad9c2-6677-4fd4-9fed-9297ef780d5a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("477af63e-c818-4ead-92e2-57d9e6a3c745"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("478dbc57-d6d0-4926-a9cd-3860a190531a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("49a8f214-8ab2-42bb-bfc5-5de5037c4dc6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("54a10746-4b97-4075-8104-f7d246359b72"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("730ec087-4bc8-45d7-b90f-ab15f0a9359a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8998c2ef-861f-46d8-a688-70931c472308"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("947b61e4-8d2f-41e9-930b-978826396ee0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a838585b-0cbe-42d2-8df6-17c6d0a8a651"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ca019809-ca67-4424-9819-6295e8bf95a9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cc6fdda7-72b7-4d9a-ab68-9054bccb4336"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d10bde03-c746-43fa-965a-2e46fb07f8dd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dec205b9-e8c6-4aca-9027-c107dd3829eb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("efe52f75-7640-4aea-b6fa-f07c9f6b01bc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fc1979ad-fd7a-4fda-abc0-4f8ac467f7f5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fc4e9267-7fd0-41a4-aed4-3b7a9974f1b8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fdd5502a-e06d-4408-88cf-100fa5b86ee1"));

            migrationBuilder.DeleteData(
                table: "CategoryProducts",
                keyColumn: "Id",
                keyValue: new Guid("47a71f1e-e386-404c-a38a-a0172124ebd8"));

            migrationBuilder.DeleteData(
                table: "CategoryProducts",
                keyColumn: "Id",
                keyValue: new Guid("6368c3a6-371b-4e71-9368-259962da5dc0"));

            migrationBuilder.DeleteData(
                table: "CategoryProducts",
                keyColumn: "Id",
                keyValue: new Guid("7ecc616c-f09b-44d4-83ab-c4d31e237eb5"));

            migrationBuilder.DeleteData(
                table: "CategoryProducts",
                keyColumn: "Id",
                keyValue: new Guid("97fba9e2-0ce4-4175-a135-f687287582b1"));

            migrationBuilder.DeleteData(
                table: "CategoryProducts",
                keyColumn: "Id",
                keyValue: new Guid("f1de3e56-cee8-43f9-a90d-61e21feb262b"));

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Orders");

            migrationBuilder.InsertData(
                table: "CategoryProducts",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1444a460-9f4f-495a-8075-2c2c38f0884c"), "Фрукты" },
                    { new Guid("4c8d62ea-e2f7-4526-a7b8-9211f64c8426"), "Молочные продукты" },
                    { new Guid("79629e33-966e-4002-89be-fb98312fd97b"), "Овощи" },
                    { new Guid("8f98165e-5cfa-46f3-b864-181b4b26517b"), "Хлеб и выпечка" },
                    { new Guid("c05fb759-953f-4276-84e4-30db87d639e7"), "Сладости" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryProductId", "ImageURL", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("08791d3f-001e-4568-964a-c40d08dce62f"), new Guid("79629e33-966e-4002-89be-fb98312fd97b"), "/ImagesForCursach/Vegetabbles/Tomatoes.png", "Помидоры", 65m },
                    { new Guid("155ca4fd-da69-4569-bf05-1c6567147954"), new Guid("1444a460-9f4f-495a-8075-2c2c38f0884c"), "/ImagesForCursach/Fruits/Pears.png", "Груши", 45m },
                    { new Guid("1755aa7b-bd49-4142-96d1-25cfa579f78f"), new Guid("8f98165e-5cfa-46f3-b864-181b4b26517b"), "/ImagesForCursach/BreadAndPastries/CheseCake.png", "Ватрушка", 50m },
                    { new Guid("1ab355b4-f87a-4d3c-83c1-b2a5bd2a497d"), new Guid("1444a460-9f4f-495a-8075-2c2c38f0884c"), "/ImagesForCursach/Fruits/Oranges.png", "Апельсины", 60m },
                    { new Guid("21bcfc56-58d6-420b-b7e1-d503ce4145f2"), new Guid("79629e33-966e-4002-89be-fb98312fd97b"), "/ImagesForCursach/Vegetabbles/Carrots.png", "Морковь", 50m },
                    { new Guid("29864449-0da2-4d4c-b050-267be9338c37"), new Guid("1444a460-9f4f-495a-8075-2c2c38f0884c"), "/ImagesForCursach/Fruits/Banan.png", "Бананы", 70m },
                    { new Guid("325f9548-6ba5-4991-8968-150975b6fda2"), new Guid("c05fb759-953f-4276-84e4-30db87d639e7"), "/ImagesForCursach/Sweets/IceCream.png", "Мороженое", 100m },
                    { new Guid("342da0b8-e2ff-449d-94d3-1b63ba06d302"), new Guid("c05fb759-953f-4276-84e4-30db87d639e7"), "/ImagesForCursach/Sweets/Candy.png", "Конфеты", 25m },
                    { new Guid("382d33a5-9ea1-455c-a330-22b30628adf0"), new Guid("c05fb759-953f-4276-84e4-30db87d639e7"), "/ImagesForCursach/Sweets/Snickers.png", "Шоколадный батончик", 50m },
                    { new Guid("4df56152-aa04-4bc6-be2c-2d34abfe5e34"), new Guid("4c8d62ea-e2f7-4526-a7b8-9211f64c8426"), "/ImagesForCursach/MilkProducts/Milk.png", "Молоко", 80m },
                    { new Guid("5a068db7-db41-4cc2-838b-8c67ba2c036e"), new Guid("79629e33-966e-4002-89be-fb98312fd97b"), "/ImagesForCursach/Vegetabbles/Cucumbers.png", "Огурцы", 70m },
                    { new Guid("648ea324-56b1-4889-8a4a-c5ee63e35cad"), new Guid("c05fb759-953f-4276-84e4-30db87d639e7"), "/ImagesForCursach/Sweets/Biscuits.png", "Печенье", 30m },
                    { new Guid("64b059cc-6c85-4aaf-b698-c55e932a1025"), new Guid("8f98165e-5cfa-46f3-b864-181b4b26517b"), "/ImagesForCursach/BreadAndPastries/Baton.png", "Батон", 25m },
                    { new Guid("78ecc6a8-ce69-4722-b523-5ea5d8e027ec"), new Guid("8f98165e-5cfa-46f3-b864-181b4b26517b"), "/ImagesForCursach/BreadAndPastries/AppleCake.png", "Пирог с яблоками", 120m },
                    { new Guid("8b318592-5235-4a0a-a9c4-976c8d01d5d6"), new Guid("79629e33-966e-4002-89be-fb98312fd97b"), "/ImagesForCursach/Vegetabbles/Potatoes.png", "Картофель", 40m },
                    { new Guid("98737da3-c3d4-426d-b964-aeab20fe0164"), new Guid("1444a460-9f4f-495a-8075-2c2c38f0884c"), "/ImagesForCursach/Fruits/Apples.png", "Яблоки", 80m },
                    { new Guid("9fb0a17c-dcc7-4768-817d-4c0da03863d2"), new Guid("1444a460-9f4f-495a-8075-2c2c38f0884c"), "/ImagesForCursach/Fruits/Grapefruit.png", "Грейпфрут", 55m },
                    { new Guid("9fdff856-a2b8-4ebd-b927-144594a4813b"), new Guid("8f98165e-5cfa-46f3-b864-181b4b26517b"), "/ImagesForCursach/BreadAndPastries/Bread.png", "Хлеб белый", 35m },
                    { new Guid("9ffb4093-c66a-4963-85af-64e4cddfb7a8"), new Guid("8f98165e-5cfa-46f3-b864-181b4b26517b"), "/ImagesForCursach/BreadAndPastries/BreadAndRollRaisin.png", "Булочка с изюмом", 40m },
                    { new Guid("a02c4b27-0c16-44d2-b6d6-2ca2ac234a42"), new Guid("79629e33-966e-4002-89be-fb98312fd97b"), "/ImagesForCursach/Vegetabbles/Onions.png", "Лук", 30m },
                    { new Guid("ca8c600c-53ff-477c-8b3b-07a8167dea4d"), new Guid("4c8d62ea-e2f7-4526-a7b8-9211f64c8426"), "/ImagesForCursach/MilkProducts/Yoghurt.png", "Йогурт", 40m },
                    { new Guid("d361cf7b-3050-485f-874a-b22c4c7c52be"), new Guid("4c8d62ea-e2f7-4526-a7b8-9211f64c8426"), "/ImagesForCursach/MilkProducts/SourCream.png", "Сметана", 60m },
                    { new Guid("f454eecd-7b46-498f-a4b4-fa299a267a79"), new Guid("4c8d62ea-e2f7-4526-a7b8-9211f64c8426"), "/ImagesForCursach/MilkProducts/ButterMilk.png", "Кефир", 50m },
                    { new Guid("fde04e4f-4642-43dd-8973-a2576d4de748"), new Guid("c05fb759-953f-4276-84e4-30db87d639e7"), "/ImagesForCursach/Sweets/Marmalade.png", "Мармелад", 40m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_UserId",
                table: "Orders",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_UserId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_UserId",
                table: "Orders");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("08791d3f-001e-4568-964a-c40d08dce62f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("155ca4fd-da69-4569-bf05-1c6567147954"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1755aa7b-bd49-4142-96d1-25cfa579f78f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1ab355b4-f87a-4d3c-83c1-b2a5bd2a497d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("21bcfc56-58d6-420b-b7e1-d503ce4145f2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("29864449-0da2-4d4c-b050-267be9338c37"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("325f9548-6ba5-4991-8968-150975b6fda2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("342da0b8-e2ff-449d-94d3-1b63ba06d302"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("382d33a5-9ea1-455c-a330-22b30628adf0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4df56152-aa04-4bc6-be2c-2d34abfe5e34"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5a068db7-db41-4cc2-838b-8c67ba2c036e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("648ea324-56b1-4889-8a4a-c5ee63e35cad"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("64b059cc-6c85-4aaf-b698-c55e932a1025"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("78ecc6a8-ce69-4722-b523-5ea5d8e027ec"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8b318592-5235-4a0a-a9c4-976c8d01d5d6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("98737da3-c3d4-426d-b964-aeab20fe0164"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9fb0a17c-dcc7-4768-817d-4c0da03863d2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9fdff856-a2b8-4ebd-b927-144594a4813b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9ffb4093-c66a-4963-85af-64e4cddfb7a8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a02c4b27-0c16-44d2-b6d6-2ca2ac234a42"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ca8c600c-53ff-477c-8b3b-07a8167dea4d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d361cf7b-3050-485f-874a-b22c4c7c52be"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f454eecd-7b46-498f-a4b4-fa299a267a79"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fde04e4f-4642-43dd-8973-a2576d4de748"));

            migrationBuilder.DeleteData(
                table: "CategoryProducts",
                keyColumn: "Id",
                keyValue: new Guid("1444a460-9f4f-495a-8075-2c2c38f0884c"));

            migrationBuilder.DeleteData(
                table: "CategoryProducts",
                keyColumn: "Id",
                keyValue: new Guid("4c8d62ea-e2f7-4526-a7b8-9211f64c8426"));

            migrationBuilder.DeleteData(
                table: "CategoryProducts",
                keyColumn: "Id",
                keyValue: new Guid("79629e33-966e-4002-89be-fb98312fd97b"));

            migrationBuilder.DeleteData(
                table: "CategoryProducts",
                keyColumn: "Id",
                keyValue: new Guid("8f98165e-5cfa-46f3-b864-181b4b26517b"));

            migrationBuilder.DeleteData(
                table: "CategoryProducts",
                keyColumn: "Id",
                keyValue: new Guid("c05fb759-953f-4276-84e4-30db87d639e7"));

            migrationBuilder.AddColumn<Guid>(
                name: "ApplicationUserId",
                table: "Orders",
                type: "uuid",
                nullable: true);

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
                name: "IX_Orders_ApplicationUserId",
                table: "Orders",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_ApplicationUserId",
                table: "Orders",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
