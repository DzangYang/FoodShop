using FoodShop.Application.DTO;
using FoodShop.Domain.Domain.Entities;
using FoodShop.Domain.Domain.Paginated;

namespace FoodShop.Application.Services.ProductService;
public interface IProductService : IBaseService<Product, CreateProductDTO>
{
    Task<PagedList<ProductDTO>> GetPaginate(int pageSize, int pageNumber);
    ProductDTO GetItem(Guid productId);
    Task<CategoryDto> GetCategoryById(Guid cateoryId);

}
