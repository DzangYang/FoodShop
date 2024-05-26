using FoodShop.Application.DTO;
using FoodShop.Domain.Domain.Interfaces.IRepositoryes;
using FoodShop.Domain.Domain.Paginated;

namespace FoodShop.Application.Services.ProductService;
public class ProductService(IProductRepository productRepository) : IProductService
{
    public CreateProductDTO GetById(Guid id)
    {
        throw new NotImplementedException();
    }

    public ProductDTO GetItem(Guid productId)
    {
        var product = productRepository.GetItemById(productId);

        var item = new ProductDTO()
        {
            Id = productId,
            CategoryId = product.CategoryProduct.Id.ToString(),
            CategoryName = product.CategoryProduct.Name,
            ImageURL = product.ImageURL,
            Name = product.Name,
            Price = product.Price,
        };

        return item;
    }

    public PagedList<ProductDTO> GetPaginate(int pageSize, int pageNumber)
    {
        var pagedList = productRepository.GetPaginated(pageSize, pageNumber);

        var items = pagedList.Items.Select(x => new ProductDTO()
        {
            Name = x.Name,
            CategoryId = x.CategoryProduct.Id.ToString(),
            CategoryName = x.CategoryProduct.Name,
            ImageURL = x.ImageURL,
            Price = x.Price,

        }).ToList();

        PagedList<ProductDTO> result = new PagedList<ProductDTO>(items, pagedList.PageNumber, pagedList.PageSize, pagedList.TotalCount);

        return result;
    }
}


