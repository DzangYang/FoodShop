using FoodShop.Application.DTO;

namespace FoodShop.Application.Services.WalletService;
public interface IWalletService
{
    void Create(CreateWalletDTO createWallet);
    Task Cancellation(int amount);
}
