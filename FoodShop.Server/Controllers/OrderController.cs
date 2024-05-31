using FoodShop.Application.DTO;
using FoodShop.Application.Services.OrderService;
using FoodShop.Domain.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace FoodShop.Server.Controllers;
[Route("api/[controller]")]
[ApiController]
public class OrderController(IOrderService orderService) : ControllerBase
{

    [HttpPost("Create")]
    public async Task<ActionResult> Create(CreateOrderDTO orderDTO)
    {
        foreach(var sale in orderDTO.Sales)
            if (sale.Qantity <= 0 || sale.TotalPrice <= 0)
                return BadRequest();

        await orderService.Create(orderDTO);
        return Ok();
    }
}
