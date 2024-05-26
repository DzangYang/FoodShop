using FoodShop.Domain.Domain.Entities;

namespace FoodShop.Domain.Domain.Interfaces.IRepositoryes;
public interface IBonusCardRepository : IBaseRepository<BonusCard>
{
    bool ExistForUser(Guid id);
    /// <summary>
    /// Получить по айди
    /// </summary>
    /// <param name="id">айди текущего пользователя к которому привязана </param>
    /// <returns></returns>
    BonusCard GetByUserId(Guid userId);






    //IList<bonus> GetAll();
}
