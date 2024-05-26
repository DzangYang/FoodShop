using FoodShop.Application.DTO;
using FoodShop.Application.Services.OrderService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FoodShop.Server.Controllers;
[Route("api/[controller]")]
[ApiController]
public class OrderController(IOrderService orderService) : ControllerBase
{

    [HttpPost("Create")]
    public IActionResult Create(CreateOrderDTO orderDTO)
    {
        orderService.Create(orderDTO);
        return Ok();
    }
}
