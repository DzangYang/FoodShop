using FoodShop.Domain.Domain.Entities;

namespace FoodShop.Application.DTO;
public class CreateProductDTO
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public IList<Sale> Sales { get; set; }

}
