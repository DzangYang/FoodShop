using FoodShop.Domain.Domain.Entities.Common;

namespace FoodShop.Domain.Domain.Entities;

/// <summary>
/// Продажа
/// </summary>
public class Sale : EntityBase
{
    /// <summary>
    /// Айди заказа
    /// </summary>
    public Guid OrderId { get; set; }

    /// <summary>
    /// Заказ
    /// </summary>
    public Order Order { get; set; }

    /// <summary>
    /// Айди товара
    /// </summary>
    public Guid ProductId { get; set; }

    /// <summary>
    /// Товар
    /// </summary>
    public Product Product { get; set; }

    /// <summary>
    /// Количество товара в продаже
    /// </summary>
    public int Qantity { get; set; }
    /// <summary>
    /// Итоговая сумма продажи
    /// </summary>
    public decimal TotalPrice { get; set; }
}
