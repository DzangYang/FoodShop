using FoodShop.Application.DTO;
using FoodShop.Domain.Domain.Entities;
using FoodShop.Domain.Domain.Interfaces.IRepositoryes;
using FoodShop.Domain.Domain.Paginated;
using FoodShop.Persistance.Database;
using FoodShop.Persistance.Repository.Paginated;
using Microsoft.EntityFrameworkCore;

namespace FoodShop.Persistance.Repository;
public class ProductRepository(ApplicationDbContext dbContext) : IProductRepository
{
    public void Create(Product entityDto)
    {
        dbContext.Products.Add(entityDto);
        dbContext.SaveChanges();
    }

    public void Delete(Guid id)
    {
        var findProduct = dbContext.Products.FirstOrDefault(p => p.Id == id);
        if (findProduct != null) return;
        dbContext.Products.Remove(findProduct);
        dbContext.SaveChanges();
    }

    public IList<Product> GetAll()
    {
        return dbContext.Products.ToList();
    }

    public Product GetItemById(Guid productId)
    {
        var product = dbContext.Products.Include(c => c.CategoryProduct).FirstOrDefault(p => p.Id == productId);

        if(product == null) 
            throw new Exception();

         return product;
    }

    PagedList<Product> IProductRepository.GetPaginated(int pageSize, int pageNumber)
    {
    
        var productsResponceQuery = dbContext.Products.Include(x => x.CategoryProduct).ToList();

        var products = productsResponceQuery.ToPagedList(pageSize, pageNumber);

        return products;
    }


}
