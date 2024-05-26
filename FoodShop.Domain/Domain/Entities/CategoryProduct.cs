using FoodShop.Domain.Domain.Entities.Common;

namespace FoodShop.Domain.Domain.Entities;
public class CategoryProduct : EntityBase
{
    /// <summary>
    /// Наименование категории
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Список товаров категории
    /// </summary>
    public IList<Product> Products { get; set; }
}
