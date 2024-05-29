﻿// <auto-generated />
using System;
using FoodShop.Persistance.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FoodShop.Persistance.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240527153214_init2")]
    partial class init2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("FoodShop.Domain.Domain.Entities.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<decimal>("Cash")
                        .HasColumnType("numeric");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("FoodShop.Domain.Domain.Entities.BonusCard", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<string>("Account")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Amount")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("BonusCards");
                });

            modelBuilder.Entity("FoodShop.Domain.Domain.Entities.CategoryProduct", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("CategoryProducts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6b6ddc99-3a7d-49ad-9cab-e5523c5c30a2"),
                            Name = "Овощи"
                        },
                        new
                        {
                            Id = new Guid("fe11a9fa-74bf-4854-bff4-4e98da1aef9f"),
                            Name = "Фрукты"
                        },
                        new
                        {
                            Id = new Guid("d2c6b140-a1fe-4c11-9062-2c8672ae9c62"),
                            Name = "Хлеб и выпечка"
                        },
                        new
                        {
                            Id = new Guid("9a42f948-e996-49a5-a2cb-60174e4cc683"),
                            Name = "Молочные продукты"
                        },
                        new
                        {
                            Id = new Guid("e5ed8bd3-6955-4344-80e0-840e802f4f24"),
                            Name = "Сладости"
                        });
                });

            modelBuilder.Entity("FoodShop.Domain.Domain.Entities.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("ApplicationUserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Payment")
                        .HasColumnType("integer");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("FoodShop.Domain.Domain.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("CategoryProductId")
                        .HasColumnType("uuid");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("CategoryProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c70efe9f-ac44-43b9-8610-1d32091bd171"),
                            CategoryProductId = new Guid("6b6ddc99-3a7d-49ad-9cab-e5523c5c30a2"),
                            ImageURL = "/ImagesForCursach/Vegetabbles/Cucumbers.png",
                            Name = "Огурцы",
                            Price = 70m
                        },
                        new
                        {
                            Id = new Guid("02d25214-9cac-42be-b429-6509b39df7f4"),
                            CategoryProductId = new Guid("6b6ddc99-3a7d-49ad-9cab-e5523c5c30a2"),
                            ImageURL = "/ImagesForCursach/Vegetabbles/Tomatoes.png",
                            Name = "Помидоры",
                            Price = 65m
                        },
                        new
                        {
                            Id = new Guid("d55e24fb-3735-4416-843a-9016497bb56d"),
                            CategoryProductId = new Guid("6b6ddc99-3a7d-49ad-9cab-e5523c5c30a2"),
                            ImageURL = "/ImagesForCursach/Vegetabbles/Carrots.png",
                            Name = "Морковь",
                            Price = 50m
                        },
                        new
                        {
                            Id = new Guid("9630be90-caa6-4f1f-89a3-c7f0f87f2155"),
                            CategoryProductId = new Guid("6b6ddc99-3a7d-49ad-9cab-e5523c5c30a2"),
                            ImageURL = "/ImagesForCursach/Vegetabbles/Potatoes.png",
                            Name = "Картофель",
                            Price = 40m
                        },
                        new
                        {
                            Id = new Guid("6c0bdbfe-b388-4533-9e89-c2c105e9607a"),
                            CategoryProductId = new Guid("6b6ddc99-3a7d-49ad-9cab-e5523c5c30a2"),
                            ImageURL = "/ImagesForCursach/Vegetabbles/Onions.png",
                            Name = "Лук",
                            Price = 30m
                        },
                        new
                        {
                            Id = new Guid("6ca047d8-2577-4347-8def-93eb84d02189"),
                            CategoryProductId = new Guid("fe11a9fa-74bf-4854-bff4-4e98da1aef9f"),
                            ImageURL = "/ImagesForCursach/Fruits/Apples.png",
                            Name = "Яблоки",
                            Price = 80m
                        },
                        new
                        {
                            Id = new Guid("4dd77340-62ab-41a9-bff6-f9c5d807444f"),
                            CategoryProductId = new Guid("fe11a9fa-74bf-4854-bff4-4e98da1aef9f"),
                            ImageURL = "/ImagesForCursach/Fruits/Banan.png",
                            Name = "Бананы",
                            Price = 70m
                        },
                        new
                        {
                            Id = new Guid("fe98004f-08e1-44a8-ab0e-41a275b74515"),
                            CategoryProductId = new Guid("fe11a9fa-74bf-4854-bff4-4e98da1aef9f"),
                            ImageURL = "/ImagesForCursach/Fruits/Oranges.png",
                            Name = "Апельсины",
                            Price = 60m
                        },
                        new
                        {
                            Id = new Guid("4cfc3d1a-b607-4c18-aa61-bf814df5e7bc"),
                            CategoryProductId = new Guid("fe11a9fa-74bf-4854-bff4-4e98da1aef9f"),
                            ImageURL = "/ImagesForCursach/Fruits/Grapefruit.png",
                            Name = "Грейпфрут",
                            Price = 55m
                        },
                        new
                        {
                            Id = new Guid("1341da9f-2717-4670-8a56-97474e2d75e3"),
                            CategoryProductId = new Guid("fe11a9fa-74bf-4854-bff4-4e98da1aef9f"),
                            ImageURL = "/ImagesForCursach/Fruits/Pears.png",
                            Name = "Груши",
                            Price = 45m
                        },
                        new
                        {
                            Id = new Guid("2cf520ac-9409-4c69-8e7e-20261d6dba0e"),
                            CategoryProductId = new Guid("d2c6b140-a1fe-4c11-9062-2c8672ae9c62"),
                            ImageURL = "/ImagesForCursach/BreadAndPastries/Bread.png",
                            Name = "Хлеб белый",
                            Price = 35m
                        },
                        new
                        {
                            Id = new Guid("719a2a32-723e-4422-bd81-f8b30b523816"),
                            CategoryProductId = new Guid("d2c6b140-a1fe-4c11-9062-2c8672ae9c62"),
                            ImageURL = "/ImagesForCursach/BreadAndPastries/Baton.png",
                            Name = "Батон",
                            Price = 25m
                        },
                        new
                        {
                            Id = new Guid("1da796d2-5119-4577-b826-97c639af0aa1"),
                            CategoryProductId = new Guid("d2c6b140-a1fe-4c11-9062-2c8672ae9c62"),
                            ImageURL = "/ImagesForCursach/BreadAndPastries/BreadAndRollRaisin.png",
                            Name = "Булочка с изюмом",
                            Price = 40m
                        },
                        new
                        {
                            Id = new Guid("0f7660bb-9ee9-41bf-a79a-c26d64158957"),
                            CategoryProductId = new Guid("d2c6b140-a1fe-4c11-9062-2c8672ae9c62"),
                            ImageURL = "/ImagesForCursach/BreadAndPastries/AppleCake.png",
                            Name = "Пирог с яблоками",
                            Price = 120m
                        },
                        new
                        {
                            Id = new Guid("2b68a25a-b558-4a81-90f6-17333ba18556"),
                            CategoryProductId = new Guid("d2c6b140-a1fe-4c11-9062-2c8672ae9c62"),
                            ImageURL = "/ImagesForCursach/BreadAndPastries/CheseCake.png",
                            Name = "Ватрушка",
                            Price = 50m
                        },
                        new
                        {
                            Id = new Guid("8b7f8028-1841-48d1-95b0-8bff56342323"),
                            CategoryProductId = new Guid("9a42f948-e996-49a5-a2cb-60174e4cc683"),
                            ImageURL = "/ImagesForCursach/MilkProducts/Milk.png",
                            Name = "Молоко",
                            Price = 80m
                        },
                        new
                        {
                            Id = new Guid("f02e7525-7961-43c3-a976-0d962da768b5"),
                            CategoryProductId = new Guid("9a42f948-e996-49a5-a2cb-60174e4cc683"),
                            ImageURL = "/ImagesForCursach/MilkProducts/SourCream.png",
                            Name = "Сметана",
                            Price = 60m
                        },
                        new
                        {
                            Id = new Guid("5d502200-e4f7-4006-ba4a-ce06bc4edb43"),
                            CategoryProductId = new Guid("9a42f948-e996-49a5-a2cb-60174e4cc683"),
                            ImageURL = "/ImagesForCursach/MilkProducts/ButterMilk.png",
                            Name = "Кефир",
                            Price = 50m
                        },
                        new
                        {
                            Id = new Guid("7c05f215-404d-451d-9d53-e13f8e9f5e59"),
                            CategoryProductId = new Guid("9a42f948-e996-49a5-a2cb-60174e4cc683"),
                            ImageURL = "/ImagesForCursach/MilkProducts/Yoghurt.png",
                            Name = "Йогурт",
                            Price = 40m
                        },
                        new
                        {
                            Id = new Guid("9cc94e60-1745-4003-9754-26eba5e7a58f"),
                            CategoryProductId = new Guid("e5ed8bd3-6955-4344-80e0-840e802f4f24"),
                            ImageURL = "/ImagesForCursach/Sweets/Snickers.png",
                            Name = "Шоколадный батончик",
                            Price = 50m
                        },
                        new
                        {
                            Id = new Guid("dc559fc7-ee57-488f-99f6-7c2eb2b4df29"),
                            CategoryProductId = new Guid("e5ed8bd3-6955-4344-80e0-840e802f4f24"),
                            ImageURL = "/ImagesForCursach/Sweets/Marmalade.png",
                            Name = "Мармелад",
                            Price = 40m
                        },
                        new
                        {
                            Id = new Guid("f4e747c3-ef26-40c5-bc71-4bca2224787e"),
                            CategoryProductId = new Guid("e5ed8bd3-6955-4344-80e0-840e802f4f24"),
                            ImageURL = "/ImagesForCursach/Sweets/Biscuits.png",
                            Name = "Печенье",
                            Price = 30m
                        },
                        new
                        {
                            Id = new Guid("75c92f6b-2fe3-4cb2-9540-bb49a253417f"),
                            CategoryProductId = new Guid("e5ed8bd3-6955-4344-80e0-840e802f4f24"),
                            ImageURL = "/ImagesForCursach/Sweets/Candy.png",
                            Name = "Конфеты",
                            Price = 25m
                        },
                        new
                        {
                            Id = new Guid("1c40df80-bbc6-42f1-bbb9-0abb0bb2e810"),
                            CategoryProductId = new Guid("e5ed8bd3-6955-4344-80e0-840e802f4f24"),
                            ImageURL = "/ImagesForCursach/Sweets/IceCream.png",
                            Name = "Мороженое",
                            Price = 100m
                        });
                });

            modelBuilder.Entity("FoodShop.Domain.Domain.Entities.Sale", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uuid");

                    b.Property<int>("Qantity")
                        .HasColumnType("integer");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("FoodShop.Domain.Domain.Entities.Wallet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<decimal>("Amount")
                        .HasColumnType("numeric");

                    b.Property<string>("CVV")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("HolderName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.ToTable("Wallets");
                });

            modelBuilder.Entity("FoodShop.Domain.Domain.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("FoodShop.Domain.Domain.Entities.BonusCard", b =>
                {
                    b.HasOne("FoodShop.Domain.Domain.Entities.ApplicationUser", null)
                        .WithOne("BonusCard")
                        .HasForeignKey("FoodShop.Domain.Domain.Entities.BonusCard", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FoodShop.Domain.Domain.Entities.Order", b =>
                {
                    b.HasOne("FoodShop.Domain.Domain.Entities.ApplicationUser", null)
                        .WithMany("Orders")
                        .HasForeignKey("ApplicationUserId");
                });

            modelBuilder.Entity("FoodShop.Domain.Domain.Entities.Product", b =>
                {
                    b.HasOne("FoodShop.Domain.Domain.Entities.CategoryProduct", "CategoryProduct")
                        .WithMany("Products")
                        .HasForeignKey("CategoryProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CategoryProduct");
                });

            modelBuilder.Entity("FoodShop.Domain.Domain.Entities.Sale", b =>
                {
                    b.HasOne("FoodShop.Domain.Domain.Entities.Order", "Order")
                        .WithMany("Sales")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FoodShop.Domain.Domain.Entities.Product", "Product")
                        .WithMany("Sales")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("FoodShop.Domain.Domain.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("FoodShop.Domain.Domain.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("FoodShop.Domain.Domain.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("FoodShop.Domain.Domain.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FoodShop.Domain.Domain.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("FoodShop.Domain.Domain.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FoodShop.Domain.Domain.Entities.ApplicationUser", b =>
                {
                    b.Navigation("BonusCard");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("FoodShop.Domain.Domain.Entities.CategoryProduct", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("FoodShop.Domain.Domain.Entities.Order", b =>
                {
                    b.Navigation("Sales");
                });

            modelBuilder.Entity("FoodShop.Domain.Domain.Entities.Product", b =>
                {
                    b.Navigation("Sales");
                });
#pragma warning restore 612, 618
        }
    }
}