using FoodShop.Domain.Domain.Entities;
using FoodShop.Domain.Domain.Interfaces.IRepositoryes;
using FoodShop.Persistance.Database;

namespace FoodShop.Persistance.Repository;
public class WalletRepository(ApplicationDbContext dbContext) : IWalletRepository
{
    public void Create(Wallet entityDto)
    {
        dbContext.Wallets.Add(entityDto);
        dbContext.SaveChanges();
    }

    public void Delete(Guid id)
    {
        var findWallet = dbContext.Wallets.FirstOrDefault(x => x.Id == id);
        if (findWallet == null) return;

        dbContext.Wallets.Remove(findWallet);
        dbContext.SaveChanges();
    }

    public bool ExistForUser(Guid userId)
    {
        var user = dbContext.Wallets.Any(u => u.UserId == userId);
        if (!user) return false;
        return true;
    }

    public IList<Wallet> GetAll()
    {
        return dbContext.Wallets.ToList();
    }

    public Wallet GetByUserId(Guid userId)
    {
        var wallet = dbContext.Wallets.FirstOrDefault(u => u.UserId == userId);

        return wallet;
    }
}
