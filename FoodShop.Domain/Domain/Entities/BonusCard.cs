using FoodShop.Domain.Domain.Entities.Common;

namespace FoodShop.Domain.Domain.Entities;
/// <summary>
/// Бонусная карта
/// </summary>
public class BonusCard : EntityBase
{

    /// Номер бонусной карты
    /// </summary>
    public string Account { get; set; }

    /// <summary>
    /// Счет
    /// </summary>
    public int Amount { get; set; }

}
