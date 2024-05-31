using FoodShop.Domain.Domain.Entities;
using FoodShop.Domain.Domain.Interfaces.IRepositoryes;
using FoodShop.Persistance.Database;

namespace FoodShop.Persistance.Repository;
public class OrderRepository(ApplicationDbContext dbContext) : IOrderRepository
{
    public void Create(Order entityDto)
    {
       
    }

    public async Task CreateAsync(Order order)
    {
        await dbContext.Orders.AddAsync(order);
        dbContext.SaveChanges();
    }

    public void Delete(Guid id)
    {
        var findOrder = dbContext.Orders.FirstOrDefault(o => o.Id == id);
        if (findOrder != null) return;
        dbContext.Orders.Remove(findOrder);
        dbContext.SaveChanges();
    }

    public IList<Order> GetAll()
    {
        return dbContext.Orders.ToList();
    }

   
}
