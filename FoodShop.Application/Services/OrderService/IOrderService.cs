using FoodShop.Application.DTO;
using FoodShop.Domain.Domain.Entities;

namespace FoodShop.Application.Services.OrderService;
public interface IOrderService
{
     Task Create(CreateOrderDTO order);
}
