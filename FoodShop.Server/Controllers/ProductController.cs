using FoodShop.Application.DTO.Requests;
using FoodShop.Application.Interfaces.Identity;
using FoodShop.Application.Services.ProductService;
using FoodShop.Domain.Domain.Interfaces.IRepositoryes;
using FoodShop.Persistance.Database;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FoodShop.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController(IProductRepository productRepository, ApplicationDbContext dbContext,
    IProductService productService, IRegistrationService registrationService,
    IHttpContextAccessor httpContext) : ControllerBase
{
    [HttpGet("api/Category/{categoryId}")]
    public IActionResult GetCategoryById(Guid categoryId)
    {
        var category = dbContext.CategoryProducts.FirstOrDefault(c => c.Id == categoryId);
        var categoryDto = new CategoryDto { Id = category.Id, Name = category.Name };
        return Ok(categoryDto);
    }

    /// <summary>
    /// Получить пагинацинный лист
    /// </summary>
    /// <param name="paginateDto">Данные для создания пагинационного листа</param>
    /// <returns></returns>
    [Authorize]
    [HttpGet("Paginate")]
    public IActionResult GetPaginated([FromQuery] CreatePaginateRequestDto paginateDto)
    {
        var result = productService.GetPaginate(paginateDto.PageNumber, paginateDto.PageSize);

        //var result = productRepository
        //    .GetPaginated(paginateDto.PageNumber, paginateDto.PageSize);

        return Ok(result);
    }

    [HttpGet("GetItem")]
    public IActionResult GetItemById(Guid productId)
    {

        var result = productService.GetItem(productId);
        return Ok(result);
    }

}
