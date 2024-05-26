using FoodShop.Domain.Domain.Entities.Common;

namespace FoodShop.Domain.Domain.Entities;

/// <summary>
/// Заказ
/// </summary>
public class Order : EntityBase
{
    /// <summary>
    /// Айди пользователя заказа
    /// </summary>
    public Guid UserId { get; set; }

    /// <summary>
    /// Метод оплаты заказа
    /// </summary>
    public WayOfPayment Payment { get; set; }

    /// <summary>
    /// Дата создания заказа
    /// </summary>
    public DateTime CreateDate { get; set; }

    /// <summary>
    /// Список продаж в заказе
    /// </summary>
    public IList<Sale> Sales { get; set; }
}

/// <summary>
/// Методы оплаты заказа
/// </summary>
public enum WayOfPayment
{
    BonusCard,
    Wallet,
    CashPayment
}
