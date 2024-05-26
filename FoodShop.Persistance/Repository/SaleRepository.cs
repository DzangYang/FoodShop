using FoodShop.Domain.Domain.Entities;
using FoodShop.Domain.Domain.Interfaces.IRepositoryes;
using FoodShop.Persistance.Database;

namespace FoodShop.Persistance.Repository;
public class SaleRepository(ApplicationDbContext dbContext) : ISaleRepository
{
    public void Create(Sale entityDto)
    {
        dbContext.Sales.Add(entityDto);
    }

    public void Delete(Guid id)
    {
        var findSale = dbContext.Sales.FirstOrDefault(s => s.Id == id);
        if (findSale != null) return;
        dbContext.Sales.Remove(findSale);
    }

    public IList<Sale> GetAll()
    {
        return dbContext.Sales.ToList();
    }

    public IList<Tdto> GetPaginated<Tdto>(int pageSize, int pageNumber)
    {
        throw new NotImplementedException();
    }
}
