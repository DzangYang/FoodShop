namespace FoodShop.Domain.Domain.Interfaces.IRepositoryes;

public interface IBaseRepository<TEntity> where TEntity : class
{
    void Create(TEntity entityDto);
    void Delete(Guid id);
    IList<TEntity> GetAll();
}
