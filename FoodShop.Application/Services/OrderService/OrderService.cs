using FoodShop.Application.DTO;
using FoodShop.Application.Services.BonusCardService;
using FoodShop.Domain.Domain.Entities;
using FoodShop.Domain.Domain.Interfaces.IRepositoryes;

namespace FoodShop.Application.Services.OrderService;
public class OrderService(IOrderRepository orderRepository, ICurrentUserService currentUserService) : IOrderService
{
    public void Create(CreateOrderDTO orderDTO)
    {
        if (orderDTO == null)
            throw new Exception();
        var orderId = Guid.NewGuid();
        var sales = orderDTO.Sales.Select(s => new Sale()
        {
            OrderId = orderId,
            ProductId = s.ProductId,
            Qantity = s.Qantity,
            TotalPrice = s.TotalPrice,
            
        }).ToList();
        var order = new Order()
        {
            CreateDate = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc),
            Payment = orderDTO.Payment,
            UserId = currentUserService.Id,
            Id = orderId,
            Sales = sales
        };

        orderRepository.Create(order);

    }
}
