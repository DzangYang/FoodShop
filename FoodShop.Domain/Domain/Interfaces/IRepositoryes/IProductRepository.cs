using FoodShop.Domain.Domain.Entities;
using FoodShop.Domain.Domain.Paginated;
using System.Runtime.InteropServices;

namespace FoodShop.Domain.Domain.Interfaces.IRepositoryes;
public interface IProductRepository : IBaseRepository<Product>
{
    /// <summary>
    /// Получить пагинацию
    /// </summary>
    /// <param name="pageSize">Размер страницы</param>
    /// <param name="pageNumber">Номер страницы</param>
    /// <param name="items"></param>
    /// <returns></returns>
    Task<PagedList<Product>> GetPaginated(int pageSize, int pageNumber);

    Product GetItemById(Guid productId);
    Task<CategoryProduct> GetCategoryById(Guid categoryId);


}
