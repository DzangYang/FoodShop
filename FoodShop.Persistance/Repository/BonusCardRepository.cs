using FoodShop.Domain.Domain.Entities;
using FoodShop.Domain.Domain.Interfaces.IRepositoryes;
using FoodShop.Persistance.Database;

namespace FoodShop.Persistance.Repository;
public class BonusCardRepository(ApplicationDbContext dbContext) : IBonusCardRepository
{
    public void Create(BonusCard entityDto)
    {
        dbContext.BonusCards.Add(entityDto);
        dbContext.SaveChanges();
    }



    public void Delete(Guid id)
    {
        var findBonusCard = dbContext.BonusCards.FirstOrDefault(b => b.Id == id);
        if (findBonusCard == null)
            throw new Exception("Бонусной карты не существует");

        dbContext.BonusCards.Remove(findBonusCard);
        dbContext.SaveChanges();
    }

    public void Delete()
    {
        throw new NotImplementedException();
    }


    public bool ExistForUser(Guid userId)
    {
        var user = dbContext.BonusCards.Any(u => u.Id == userId);
        if (!user) return false;
        return true;
    }

    public IList<BonusCard> GetAll()
    {
        return dbContext.BonusCards.ToList();
    }


    public BonusCard GetByUserId(Guid userId)
    {
        var bonusCard = dbContext.BonusCards.FirstOrDefault(b => b.Id == userId);

        return bonusCard;
    }
}
