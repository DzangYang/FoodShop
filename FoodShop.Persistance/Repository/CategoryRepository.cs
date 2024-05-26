using FoodShop.Domain.Domain.Entities;
using FoodShop.Domain.Domain.Interfaces.IRepositoryes;
using FoodShop.Persistance.Database;

namespace FoodShop.Persistance.Repository;
public class CategoryRepository(ApplicationDbContext dbContext) : ICategoryRepository
{
    public void Create(CategoryProduct entityDto)
    {
        dbContext.CategoryProducts.Add(entityDto);
    }

    public void Delete(Guid id)
    {
        var categoryFindId = dbContext.CategoryProducts.FirstOrDefault(c => c.Id == id);
        if (categoryFindId == null) return;
        dbContext.CategoryProducts.Remove(categoryFindId);
    }

    public IList<CategoryProduct> GetAll()
    {
        return dbContext.CategoryProducts.ToList();
    }

    public IList<Tdto> GetPaginated<Tdto>(int pageSize, int pageNumber)
    {
        throw new NotImplementedException();
    }
}
