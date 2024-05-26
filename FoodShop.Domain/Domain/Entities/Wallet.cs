using FoodShop.Domain.Domain.Entities.Common;

namespace FoodShop.Domain.Domain.Entities;
/// <summary>
/// Кошелек
/// </summary>
public class Wallet : EntityBase
{
    /// <summary>
    /// Айди владельца 
    /// </summary>
    public Guid UserId { get; set; }

    /// <summary>
    /// Имя владельца 
    /// </summary>
    public string HolderName { get; set; }

    /// <summary>
    /// Номер 
    /// </summary>
    public string Number { get; set; }

    /// <summary>
    /// Сvv владельца 
    /// </summary>
    public string CVV { get; set; }

    /// <summary>
    /// Срок действия 
    /// </summary>
    public DateTime ExpiryDate { get; set; }

    /// <summary>
    /// Счет 
    /// </summary>
    public decimal Amount { get; set; }

}
