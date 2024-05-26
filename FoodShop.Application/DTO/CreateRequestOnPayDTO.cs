using System.ComponentModel.DataAnnotations;

namespace FoodShop.Application.DTO;
public class CreateRequestOnPayDTO
{
    [Required]
    public Guid OrderId { get; set; }
}
