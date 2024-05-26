using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace FoodShop.Domain.Domain.Entities;

/// <summary>
/// Пользователь
/// </summary>
public class ApplicationUser : IdentityUser<Guid>
{
    /// <summary>
    /// Логин пользователя
    /// </summary>
    [Required(ErrorMessage = "Login is required")]
    public string Login { get; set; }

    /// <summary>
    /// Пароль пользователя
    /// </summary>
    [Required(ErrorMessage = "Password is required")]
    public string Password { get; set; }

    /// <summary>
    /// Бонусная карта
    /// </summary>
    public BonusCard? BonusCard { get; set; }

    /// <summary>
    /// Наличка
    /// </summary>
    public decimal Cash { get; set; }
    /// <summary>
    /// Список заказов пользователя
    /// </summary>
    public IReadOnlyList<Order> Orders { get; set; }
}
