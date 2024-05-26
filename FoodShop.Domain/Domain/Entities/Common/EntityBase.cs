namespace FoodShop.Domain.Domain.Entities.Common;

public abstract class EntityBase : IEntity
{
    public Guid Id { get; set; }
}
