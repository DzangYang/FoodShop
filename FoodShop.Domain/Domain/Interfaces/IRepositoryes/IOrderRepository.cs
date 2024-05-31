using FoodShop.Domain.Domain.Entities;

namespace FoodShop.Domain.Domain.Interfaces.IRepositoryes;
public interface IOrderRepository : IBaseRepository<Order>
{
    Task CreateAsync(Order order);
}
