using FoodShop.Application.DTO;
using FoodShop.Application.Services.BonusCardService;
using FoodShop.Domain.Domain.Entities;
using FoodShop.Domain.Domain.Interfaces.IRepositoryes;

namespace FoodShop.Application.Services.WalletService;
public class WalletService(IWalletRepository walletRepository, ICurrentUserService currentUserService) : IWalletService
{
    public async Task Cancellation(int amount)
    {
        var findWallet = walletRepository.ExistForUser(currentUserService.Id);
        if (!findWallet) throw new Exception("Безналичная карта не привязана");

        var wallet = walletRepository.GetByUserId(currentUserService.Id);
        wallet.Amount -= amount;

    }

    public void Create(CreateWalletDTO createWallet)
    {
        var findWallet = walletRepository.ExistForUser(currentUserService.Id);
        if (findWallet) throw new Exception("Безналичная карта уже привязана");

        var wallet = new Wallet()
        {
            Id = Guid.NewGuid(),
            UserId = currentUserService.Id,
            HolderName = createWallet.HolderName,
            Number = createWallet.Number,
            CVV = createWallet.CVV,
            ExpiryDate = DateTime.SpecifyKind(createWallet.ExpiryDate, DateTimeKind.Utc),

        };

        walletRepository.Create(wallet);
    }
}
