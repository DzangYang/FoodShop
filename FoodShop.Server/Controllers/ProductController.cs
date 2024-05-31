using FoodShop.Application.DTO;
using FoodShop.Application.DTO.Requests;
using FoodShop.Application.Interfaces.Identity;
using FoodShop.Application.Services.ProductService;
using FoodShop.Domain.Domain.Interfaces.IRepositoryes;
using FoodShop.Domain.Domain.Paginated;
using FoodShop.Persistance.Database;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FoodShop.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController(IProductService productService) : ControllerBase
{
    [HttpGet("api/Category/{categoryId}")]
    public async Task<ActionResult<CategoryDto>> GetCategoryById(Guid categoryId)
    {
        var categoryDto =  await productService.GetCategoryById(categoryId);

        return categoryDto != null ? Ok(categoryDto) : NotFound();
    }

    /// <summary>
    /// Получить пагинацинный лист
    /// </summary>
    /// <param name="paginateDto">Данные для создания пагинационного листа</param>
    /// <returns></returns>
    //[Authorize]
    [HttpGet("Paginate")]
    public async Task<ActionResult<PagedList<ProductDTO>>> GetPaginated([FromQuery] CreatePaginateRequestDto paginateDto)
    {
        if(paginateDto.PageNumber <= 0 || paginateDto.PageSize <= 0)
        {
            return BadRequest();
        }
        var result = await productService.GetPaginate(paginateDto.PageNumber, paginateDto.PageSize);
       
        return Ok(result);
    }

    [HttpGet("GetItem")]
    public async Task<IActionResult> GetItemById(Guid productId)
    {
        
        var result = productService.GetItem(productId);
        return result != null ? Ok(result) : NotFound();
       
    }

}
