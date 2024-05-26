using FoodShop.Application.Interfaces;
using FoodShop.Domain.Domain;
using FoodShop.Domain.Domain.Entities;
using FoodShop.Persistance.EntityTypeConfigurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FoodShop.Persistance.Database;
public class ApplicationDbContext : IdentityDbContext<ApplicationUser, Role, Guid>, IMerchandiseShopDbContext
{
    public DbSet<Order> Orders { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Sale> Sales { get; set; }
    public DbSet<CategoryProduct> CategoryProducts { get; set; }
    public DbSet<ApplicationUser> Users { get; set; }
    public DbSet<BonusCard> BonusCards { get; set; }
    public DbSet<Wallet> Wallets { get; set; }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<ApplicationUser>()
        .HasOne(u => u.BonusCard)
        .WithOne()
        .HasForeignKey<BonusCard>(b => b.Id);



        // Генерация GUID

        //Айди категории овощи
        var vegetabblesCategoryId = Guid.NewGuid();
        //Айди категории фрукты
        var fruitCategoryId = Guid.NewGuid();
        //Айди категории хлеб и выпечка
        var BreadAndPastries = Guid.NewGuid();
        //Айди категории молочные продукты
        var MilkProductsCategoryId = Guid.NewGuid();
        //Айди категории сладости
        var SweetsCategoryId = Guid.NewGuid();

        // Создание категорий
        modelBuilder.Entity<CategoryProduct>().HasData(
            new CategoryProduct[]
            {
            // Категории для взвешивания
            new CategoryProduct { Id = vegetabblesCategoryId, Name = "Овощи", Products = new List<Product>() },
            new CategoryProduct { Id = fruitCategoryId, Name = "Фрукты", Products = new List<Product>() },

            // Категории без взвешивания
            new CategoryProduct { Id = BreadAndPastries, Name = "Хлеб и выпечка", Products = new List<Product>() },
            new CategoryProduct { Id = MilkProductsCategoryId, Name = "Молочные продукты", Products = new List<Product>() },
            new CategoryProduct { Id = SweetsCategoryId, Name = "Сладости", Products = new List<Product>() },
            }
        );

        // Создание продуктов
        modelBuilder.Entity<Product>().HasData(
            new Product[]
            {
            // Овощи (для взвешивания)
            new Product { Name = "Огурцы", Price = 70, Id = Guid.NewGuid(), CategoryProductId = vegetabblesCategoryId, ImageURL = "/ImagesForCursach/Vegetabbles/Cucumbers.png" },
            new Product { Name = "Помидоры", Price = 65, Id = Guid.NewGuid(), CategoryProductId = vegetabblesCategoryId, ImageURL = "/ImagesForCursach/Vegetabbles/Tomatoes.png"},
            new Product { Name = "Морковь", Price = 50, Id = Guid.NewGuid(), CategoryProductId = vegetabblesCategoryId , ImageURL = "/ImagesForCursach/Vegetabbles/Carrots.png"},
            new Product { Name = "Картофель", Price = 40, Id = Guid.NewGuid(), CategoryProductId =vegetabblesCategoryId, ImageURL = "/ImagesForCursach/Vegetabbles/Potatoes.png"},
            new Product { Name = "Лук", Price = 30, Id = Guid.NewGuid(), CategoryProductId = vegetabblesCategoryId, ImageURL = "/ImagesForCursach/Vegetabbles/Onions.png" },
           
            // Фрукты (для взвешивания)
            new Product { Name = "Яблоки", Price = 80, Id = Guid.NewGuid(), CategoryProductId = fruitCategoryId, ImageURL = "/ImagesForCursach/Fruits/Apples.png"},
            new Product { Name = "Бананы", Price = 70, Id = Guid.NewGuid(), CategoryProductId = fruitCategoryId, ImageURL = "/ImagesForCursach/Fruits/Banan.png" },
            new Product { Name = "Апельсины", Price = 60, Id = Guid.NewGuid(), CategoryProductId = fruitCategoryId, ImageURL = "/ImagesForCursach/Fruits/Oranges.png" },
            new Product { Name = "Грейпфрут", Price = 55, Id = Guid.NewGuid(), CategoryProductId = fruitCategoryId, ImageURL = "/ImagesForCursach/Fruits/Grapefruit.png"},
            new Product { Name = "Груши", Price = 45, Id = Guid.NewGuid(), CategoryProductId = fruitCategoryId, ImageURL = "/ImagesForCursach/Fruits/Pears.png" },

            // Хлеб и выпечка (без взвешивания)
            new Product { Name = "Хлеб белый", Price = 35, Id = Guid.NewGuid(), CategoryProductId = BreadAndPastries, ImageURL = "/ImagesForCursach/BreadAndPastries/Bread.png" },
            new Product { Name = "Батон", Price = 25, Id = Guid.NewGuid(), CategoryProductId = BreadAndPastries, ImageURL = "/ImagesForCursach/BreadAndPastries/Baton.png"  },
            new Product { Name = "Булочка с изюмом", Price = 40, Id = Guid.NewGuid(), CategoryProductId = BreadAndPastries, ImageURL = "/ImagesForCursach/BreadAndPastries/BreadAndRollRaisin.png" },
            new Product { Name = "Пирог с яблоками", Price = 120, Id = Guid.NewGuid(), CategoryProductId = BreadAndPastries, ImageURL = "/ImagesForCursach/BreadAndPastries/AppleCake.png" },
            new Product { Name = "Ватрушка", Price = 50, Id = Guid.NewGuid(), CategoryProductId = BreadAndPastries, ImageURL = "/ImagesForCursach/BreadAndPastries/CheseCake.png"  },

            // Молочные продукты (без взвешивания)
            new Product { Name = "Молоко", Price = 80, Id = Guid.NewGuid(), CategoryProductId = MilkProductsCategoryId, ImageURL = "/ImagesForCursach/MilkProducts/Milk.png" },
            new Product { Name = "Сметана", Price = 60, Id = Guid.NewGuid(), CategoryProductId = MilkProductsCategoryId, ImageURL = "/ImagesForCursach/MilkProducts/SourCream.png"},
            new Product { Name = "Кефир", Price = 50, Id = Guid.NewGuid(), CategoryProductId = MilkProductsCategoryId, ImageURL = "/ImagesForCursach/MilkProducts/ButterMilk.png" },
            new Product { Name = "Йогурт", Price = 40, Id = Guid.NewGuid(), CategoryProductId = MilkProductsCategoryId, ImageURL = "/ImagesForCursach/MilkProducts/Yoghurt.png" }, 
             // Сладости (без взвешивания)
            new Product { Name = "Шоколадный батончик", Price = 50, Id = Guid.NewGuid(), CategoryProductId = SweetsCategoryId, ImageURL = "/ImagesForCursach/Sweets/Snickers.png" },
            new Product { Name = "Мармелад", Price = 40, Id = Guid.NewGuid(), CategoryProductId = SweetsCategoryId, ImageURL = "/ImagesForCursach/Sweets/Marmalade.png"},
            new Product { Name = "Печенье", Price = 30, Id = Guid.NewGuid(), CategoryProductId = SweetsCategoryId, ImageURL = "/ImagesForCursach/Sweets/Biscuits.png" },
            new Product { Name = "Конфеты", Price = 25, Id = Guid.NewGuid(), CategoryProductId = SweetsCategoryId, ImageURL = "/ImagesForCursach/Sweets/Candy.png"},
            new Product { Name = "Мороженое", Price = 100, Id = Guid.NewGuid(), CategoryProductId = SweetsCategoryId, ImageURL = "/ImagesForCursach/Sweets/IceCream.png" } }
            );


        modelBuilder.ApplyConfiguration<Order>(new MerchandiseShopConfiguration());
        modelBuilder.ApplyConfiguration<Sale>(new MerchandiseShopConfiguration());



        base.OnModelCreating(modelBuilder);
    }
}
