using FoodShop.Application.DTO;
using FoodShop.Application.Services.WalletService;
using FoodShop.Persistance.Database;
using Microsoft.AspNetCore.Mvc;

namespace FoodShop.Server.Controllers;
[Route("api/[controller]")]
[ApiController]
public class WalletController(IWalletService walletService, ApplicationDbContext dbContext) : ControllerBase
{

    [HttpPost]
    public async Task<IActionResult> Create(CreateWalletDTO createWalletDTO)
    {
        if(int.Parse(createWalletDTO.CVV) <= 0)
        {
            return BadRequest();
        }
        if(int.Parse(createWalletDTO.CVV) < 3 || int.Parse(createWalletDTO.CVV) > 3)
        {
            return BadRequest();
        }
        walletService.Create(createWalletDTO);
        return Ok();
    }

    [HttpPut("amount")]
    public async Task<IActionResult> Decreese(int amount)
    {
        try
        {
            await walletService.Cancellation(amount);
            dbContext.SaveChanges();
            return Ok();
        }
        catch (Exception)
        {

            return BadRequest("Ошибка, недостаточно средств на карте");
        }
         
    }
}
