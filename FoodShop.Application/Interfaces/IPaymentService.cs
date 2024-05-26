namespace FoodShop.Application.Interfaces;
public interface IPaymentService
{
    void Pay(Guid orderId);
}
