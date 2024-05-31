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

    public async Task<CategoryProduct> GetCategoryById(Guid categoryId)
    {
        var result = await dbContext.CategoryProducts.FirstOrDefaultAsync(c => c.Id == categoryId);
        return result;
    }

    public Product GetItemById(Guid productId)
    {
        var product = dbContext.Products.Include(c => c.CategoryProduct).FirstOrDefault(p => p.Id == productId);

        if(product == null) 
            throw new Exception();

         return product;
    }

    async Task<PagedList<Product>> IProductRepository.GetPaginated(int pageNumber, int pageSize)
    {
    
        var productsResponceQuery = await dbContext.Products.Include(x => x.CategoryProduct).ToListAsync();

        var products = productsResponceQuery.ToPagedList(pageNumber, pageSize);

        return products;
    }


}
