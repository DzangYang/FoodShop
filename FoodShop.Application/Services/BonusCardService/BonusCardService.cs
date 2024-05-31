using FoodShop.Domain.Domain.Entities;
using FoodShop.Domain.Domain.Interfaces.IRepositoryes;

namespace FoodShop.Application.Services.BonusCardService;
public class BonusCardService(IBonusCardRepository bonusCardRepository,
    ICurrentUserService currentUserService) : IBonusCardService
{
    private string Message = string.Empty;
    public void Cancellation(int amount)
    {
        try
        {
            var exist = bonusCardRepository.ExistForUser(currentUserService.Id);
            if (!exist) throw new Exception("Бонусная карта не привязана");

            var currentBonusCard = bonusCardRepository.GetByUserId(currentUserService.Id);

            if (currentBonusCard.Amount < amount)
                throw new Exception("Ошибка, недостаточно, бонусов для оплаты");

            currentBonusCard.Amount -= amount;
        }
        catch (Exception ex)
        {
            // Логгирование ошибки, если необходимо
            throw new Exception(Message = "Ошибка списания бонусов");
        }

    }

    public void Create()
    {
        try
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
        catch 
        {

            throw new Exception("Ошибка создания бонусной карты");
        }
       
    }

    public void CreateBonuses(int amountBonuses)
    {
        try
        {
            var exist = bonusCardRepository.ExistForUser(currentUserService.Id);
            if (!exist) throw new Exception("Бонусная карта не привязана");

            var currentBonusCard = bonusCardRepository.GetByUserId(currentUserService.Id);

            currentBonusCard.Amount += amountBonuses / 2;

        }
        catch 
        {

            throw new Exception("Ошибка добавления бонусов");
        }
      
    }

}

public interface ICurrentUserService
{
    public Guid Id { get; set; }
}

