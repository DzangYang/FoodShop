using FoodShop.Application.DTO;
using FoodShop.Domain.Domain.Entities;
using FoodShop.Domain.Domain.Interfaces.IRepositoryes;

namespace FoodShop.Application.Services.OrderService;
public class OrderService(IOrderRepository orderRepository) : IOrderService
{
    public void Create(CreateOrderDTO orderDTO)
    {
        if (orderDTO == null)
            throw new Exception();

        var order = new Order()
        {
            CreateDate = DateTime.Now,
            Payment = orderDTO.Payment,
            UserId = orderDTO.UserId,
            Id = Guid.NewGuid(),

        };

        orderRepository.Create(order);

    }
}
