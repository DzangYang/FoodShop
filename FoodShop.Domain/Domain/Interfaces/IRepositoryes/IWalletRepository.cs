using FoodShop.Domain.Domain.Entities;

namespace FoodShop.Domain.Domain.Interfaces.IRepositoryes;
public interface IWalletRepository : IBaseRepository<Wallet>
{
    bool ExistForUser(Guid userId);
    Wallet GetByUserId(Guid userId);


}
