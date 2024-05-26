using FoodShop.Domain.Domain.Entities;

namespace FoodShop.Application.Interfaces;
public interface IMethodPaymentOrderService
{
    public void Payment(Order order);

}
