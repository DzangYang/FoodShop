namespace FoodShop.Application.DTO;
internal class GetByIdOrderDto
{
    public Guid Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public string WayOfPayment { get; set; }
}
