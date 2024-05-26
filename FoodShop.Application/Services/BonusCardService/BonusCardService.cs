using FoodShop.Domain.Domain.Entities;
using FoodShop.Domain.Domain.Interfaces.IRepositoryes;

namespace FoodShop.Application.Services.BonusCardService;
public class BonusCardService(IBonusCardRepository bonusCardRepository,
    ICurrentUserService currentUserService) : IBonusCardService
{
    public void Create()
    {
        bool exist = bonusCardRepository.ExistForUser(currentUserService.Id);
        if (exist) throw new Exception("Бонусная карта уже привязана");

        var bonusCard = new BonusCard()
        {
            Id = currentUserService.Id,
            Account = Guid.NewGuid().ToString(),
        };

        bonusCardRepository.Create(bonusCard);

    }

    public void CreateBonuses(int amountBonuses)
    {
        var exist = bonusCardRepository.ExistForUser(currentUserService.Id);
        if (!exist) throw new Exception("Бонусная карта не привязана");

        var currentBonusCard = bonusCardRepository.GetByUserId(currentUserService.Id);

        currentBonusCard.Amount += amountBonuses;

    }

}

public interface ICurrentUserService
{
    public Guid Id { get; set; }
}

