using FoodShop.Domain.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace FoodShop.Application.Interfaces;
public interface IMerchandiseShopDbContext
{
    public DbSet<Order> Orders { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Sale> Sales { get; set; }
   
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
