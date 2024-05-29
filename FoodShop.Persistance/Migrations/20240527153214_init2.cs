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
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0247fbd8-098a-4a98-8fe5-4a2c953b267b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0f5b4833-1f9f-4730-9048-ac106f7fdb1a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("26855f80-25f1-40b1-9d0b-a1e40b085b6d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("26f0cd6f-1f7e-49f1-8a0b-94d1ba03471d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("394497ab-9cdc-447e-ae73-dac010f3ba3f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("44d20ea0-ede1-47d5-8e3e-d8adc8e6d86a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("499002a8-69da-4c0c-ac48-7e28b00d7ce8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("695f7260-8124-4aa5-b90d-830c696b8810"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6fe3639a-7d6e-46fb-bf59-818eb571f1ff"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("82f7154a-b92e-4260-95dc-251b719bbc02"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("85dd0fac-318c-4510-ae16-8d89c7456993"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8a62fc24-1d1e-4fc4-b23a-89d8ed34bd80"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9075ac9b-9e53-450c-aedb-56e1e81407b0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("956e5135-227e-4298-8ba9-060efc96fd0f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9fb80e12-82dc-449a-a3f4-48e4f0080298"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a876cf0b-6805-4a9e-a39b-18390e58e342"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ac54bcfa-343e-4394-bdc8-d58d9e2ebb32"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("baaccf4c-09e3-4f64-a01b-9cbd301f2eeb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ca394d54-8b6a-4764-b972-f5217745fc83"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d87f243b-865c-41d1-adee-09616642f6c2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e1df5688-59f9-4a2e-b570-f2af89bbbe2c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e2e05228-f208-44af-8c57-c6549b8b31aa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e3d6f06c-fa2a-4455-b77c-b9b5bf35e847"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eec7a8eb-3b29-4248-8116-f9a1dcc71716"));

            migrationBuilder.DeleteData(
                table: "CategoryProducts",
                keyColumn: "Id",
                keyValue: new Guid("0364321b-8e6a-4ea8-b4a9-f853d229ec05"));

            migrationBuilder.DeleteData(
                table: "CategoryProducts",
                keyColumn: "Id",
                keyValue: new Guid("14e3b792-74c6-4c5f-95b6-c2e18c9253d1"));

            migrationBuilder.DeleteData(
                table: "CategoryProducts",
                keyColumn: "Id",
                keyValue: new Guid("584e279d-acaa-42d9-a316-d681172a8b7a"));

            migrationBuilder.DeleteData(
                table: "CategoryProducts",
                keyColumn: "Id",
                keyValue: new Guid("887bdaf2-2fdf-493a-8779-59d36c05ec77"));

            migrationBuilder.DeleteData(
                table: "CategoryProducts",
                keyColumn: "Id",
                keyValue: new Guid("9f2ca956-b0d9-493d-94cd-86aedd0c9e8f"));

            migrationBuilder.AddColumn<decimal>(
                name: "TotalPrice",
                table: "Sales",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.InsertData(
                table: "CategoryProducts",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("6b6ddc99-3a7d-49ad-9cab-e5523c5c30a2"), "Овощи" },
                    { new Guid("9a42f948-e996-49a5-a2cb-60174e4cc683"), "Молочные продукты" },
                    { new Guid("d2c6b140-a1fe-4c11-9062-2c8672ae9c62"), "Хлеб и выпечка" },
                    { new Guid("e5ed8bd3-6955-4344-80e0-840e802f4f24"), "Сладости" },
                    { new Guid("fe11a9fa-74bf-4854-bff4-4e98da1aef9f"), "Фрукты" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryProductId", "ImageURL", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("02d25214-9cac-42be-b429-6509b39df7f4"), new Guid("6b6ddc99-3a7d-49ad-9cab-e5523c5c30a2"), "/ImagesForCursach/Vegetabbles/Tomatoes.png", "Помидоры", 65m },
                    { new Guid("0f7660bb-9ee9-41bf-a79a-c26d64158957"), new Guid("d2c6b140-a1fe-4c11-9062-2c8672ae9c62"), "/ImagesForCursach/BreadAndPastries/AppleCake.png", "Пирог с яблоками", 120m },
                    { new Guid("1341da9f-2717-4670-8a56-97474e2d75e3"), new Guid("fe11a9fa-74bf-4854-bff4-4e98da1aef9f"), "/ImagesForCursach/Fruits/Pears.png", "Груши", 45m },
                    { new Guid("1c40df80-bbc6-42f1-bbb9-0abb0bb2e810"), new Guid("e5ed8bd3-6955-4344-80e0-840e802f4f24"), "/ImagesForCursach/Sweets/IceCream.png", "Мороженое", 100m },
                    { new Guid("1da796d2-5119-4577-b826-97c639af0aa1"), new Guid("d2c6b140-a1fe-4c11-9062-2c8672ae9c62"), "/ImagesForCursach/BreadAndPastries/BreadAndRollRaisin.png", "Булочка с изюмом", 40m },
                    { new Guid("2b68a25a-b558-4a81-90f6-17333ba18556"), new Guid("d2c6b140-a1fe-4c11-9062-2c8672ae9c62"), "/ImagesForCursach/BreadAndPastries/CheseCake.png", "Ватрушка", 50m },
                    { new Guid("2cf520ac-9409-4c69-8e7e-20261d6dba0e"), new Guid("d2c6b140-a1fe-4c11-9062-2c8672ae9c62"), "/ImagesForCursach/BreadAndPastries/Bread.png", "Хлеб белый", 35m },
                    { new Guid("4cfc3d1a-b607-4c18-aa61-bf814df5e7bc"), new Guid("fe11a9fa-74bf-4854-bff4-4e98da1aef9f"), "/ImagesForCursach/Fruits/Grapefruit.png", "Грейпфрут", 55m },
                    { new Guid("4dd77340-62ab-41a9-bff6-f9c5d807444f"), new Guid("fe11a9fa-74bf-4854-bff4-4e98da1aef9f"), "/ImagesForCursach/Fruits/Banan.png", "Бананы", 70m },
                    { new Guid("5d502200-e4f7-4006-ba4a-ce06bc4edb43"), new Guid("9a42f948-e996-49a5-a2cb-60174e4cc683"), "/ImagesForCursach/MilkProducts/ButterMilk.png", "Кефир", 50m },
                    { new Guid("6c0bdbfe-b388-4533-9e89-c2c105e9607a"), new Guid("6b6ddc99-3a7d-49ad-9cab-e5523c5c30a2"), "/ImagesForCursach/Vegetabbles/Onions.png", "Лук", 30m },
                    { new Guid("6ca047d8-2577-4347-8def-93eb84d02189"), new Guid("fe11a9fa-74bf-4854-bff4-4e98da1aef9f"), "/ImagesForCursach/Fruits/Apples.png", "Яблоки", 80m },
                    { new Guid("719a2a32-723e-4422-bd81-f8b30b523816"), new Guid("d2c6b140-a1fe-4c11-9062-2c8672ae9c62"), "/ImagesForCursach/BreadAndPastries/Baton.png", "Батон", 25m },
                    { new Guid("75c92f6b-2fe3-4cb2-9540-bb49a253417f"), new Guid("e5ed8bd3-6955-4344-80e0-840e802f4f24"), "/ImagesForCursach/Sweets/Candy.png", "Конфеты", 25m },
                    { new Guid("7c05f215-404d-451d-9d53-e13f8e9f5e59"), new Guid("9a42f948-e996-49a5-a2cb-60174e4cc683"), "/ImagesForCursach/MilkProducts/Yoghurt.png", "Йогурт", 40m },
                    { new Guid("8b7f8028-1841-48d1-95b0-8bff56342323"), new Guid("9a42f948-e996-49a5-a2cb-60174e4cc683"), "/ImagesForCursach/MilkProducts/Milk.png", "Молоко", 80m },
                    { new Guid("9630be90-caa6-4f1f-89a3-c7f0f87f2155"), new Guid("6b6ddc99-3a7d-49ad-9cab-e5523c5c30a2"), "/ImagesForCursach/Vegetabbles/Potatoes.png", "Картофель", 40m },
                    { new Guid("9cc94e60-1745-4003-9754-26eba5e7a58f"), new Guid("e5ed8bd3-6955-4344-80e0-840e802f4f24"), "/ImagesForCursach/Sweets/Snickers.png", "Шоколадный батончик", 50m },
                    { new Guid("c70efe9f-ac44-43b9-8610-1d32091bd171"), new Guid("6b6ddc99-3a7d-49ad-9cab-e5523c5c30a2"), "/ImagesForCursach/Vegetabbles/Cucumbers.png", "Огурцы", 70m },
                    { new Guid("d55e24fb-3735-4416-843a-9016497bb56d"), new Guid("6b6ddc99-3a7d-49ad-9cab-e5523c5c30a2"), "/ImagesForCursach/Vegetabbles/Carrots.png", "Морковь", 50m },
                    { new Guid("dc559fc7-ee57-488f-99f6-7c2eb2b4df29"), new Guid("e5ed8bd3-6955-4344-80e0-840e802f4f24"), "/ImagesForCursach/Sweets/Marmalade.png", "Мармелад", 40m },
                    { new Guid("f02e7525-7961-43c3-a976-0d962da768b5"), new Guid("9a42f948-e996-49a5-a2cb-60174e4cc683"), "/ImagesForCursach/MilkProducts/SourCream.png", "Сметана", 60m },
                    { new Guid("f4e747c3-ef26-40c5-bc71-4bca2224787e"), new Guid("e5ed8bd3-6955-4344-80e0-840e802f4f24"), "/ImagesForCursach/Sweets/Biscuits.png", "Печенье", 30m },
                    { new Guid("fe98004f-08e1-44a8-ab0e-41a275b74515"), new Guid("fe11a9fa-74bf-4854-bff4-4e98da1aef9f"), "/ImagesForCursach/Fruits/Oranges.png", "Апельсины", 60m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("02d25214-9cac-42be-b429-6509b39df7f4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0f7660bb-9ee9-41bf-a79a-c26d64158957"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1341da9f-2717-4670-8a56-97474e2d75e3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1c40df80-bbc6-42f1-bbb9-0abb0bb2e810"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1da796d2-5119-4577-b826-97c639af0aa1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2b68a25a-b558-4a81-90f6-17333ba18556"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2cf520ac-9409-4c69-8e7e-20261d6dba0e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4cfc3d1a-b607-4c18-aa61-bf814df5e7bc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4dd77340-62ab-41a9-bff6-f9c5d807444f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5d502200-e4f7-4006-ba4a-ce06bc4edb43"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6c0bdbfe-b388-4533-9e89-c2c105e9607a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6ca047d8-2577-4347-8def-93eb84d02189"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("719a2a32-723e-4422-bd81-f8b30b523816"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("75c92f6b-2fe3-4cb2-9540-bb49a253417f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7c05f215-404d-451d-9d53-e13f8e9f5e59"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8b7f8028-1841-48d1-95b0-8bff56342323"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9630be90-caa6-4f1f-89a3-c7f0f87f2155"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9cc94e60-1745-4003-9754-26eba5e7a58f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c70efe9f-ac44-43b9-8610-1d32091bd171"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d55e24fb-3735-4416-843a-9016497bb56d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dc559fc7-ee57-488f-99f6-7c2eb2b4df29"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f02e7525-7961-43c3-a976-0d962da768b5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f4e747c3-ef26-40c5-bc71-4bca2224787e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fe98004f-08e1-44a8-ab0e-41a275b74515"));

            migrationBuilder.DeleteData(
                table: "CategoryProducts",
                keyColumn: "Id",
                keyValue: new Guid("6b6ddc99-3a7d-49ad-9cab-e5523c5c30a2"));

            migrationBuilder.DeleteData(
                table: "CategoryProducts",
                keyColumn: "Id",
                keyValue: new Guid("9a42f948-e996-49a5-a2cb-60174e4cc683"));

            migrationBuilder.DeleteData(
                table: "CategoryProducts",
                keyColumn: "Id",
                keyValue: new Guid("d2c6b140-a1fe-4c11-9062-2c8672ae9c62"));

            migrationBuilder.DeleteData(
                table: "CategoryProducts",
                keyColumn: "Id",
                keyValue: new Guid("e5ed8bd3-6955-4344-80e0-840e802f4f24"));

            migrationBuilder.DeleteData(
                table: "CategoryProducts",
                keyColumn: "Id",
                keyValue: new Guid("fe11a9fa-74bf-4854-bff4-4e98da1aef9f"));

            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "Sales");

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
        }
    }
}
