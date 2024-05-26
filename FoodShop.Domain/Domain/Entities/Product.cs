using FoodShop.Domain.Domain.Entities.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodShop.Domain.Domain.Entities;

/// <summary>
/// Товар
/// </summary>
public class Product : EntityBase
{
    /// <summary>
    /// Наименование товара
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Стоимость товара
    /// </summary>
    public decimal Price { get; set; }

    /// <summary>
    /// Категория товара
    /// </summary>
    public CategoryProduct? CategoryProduct { get; set; }

    /// <summary>
    /// Айди категории
    /// </summary>
    ///
    [ForeignKey("CategoryProductId")]
    public Guid CategoryProductId { get; set; }

    /// <summary>
    /// Фото товара
    /// </summary>
    public string ImageURL { get; set; }

    /// <summary>
    /// Список продаж товара
    /// </summary>
    public IList<Sale> Sales { get; set; }

}
