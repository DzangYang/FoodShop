using FoodShop.Application.Services.BonusCardService;
using FoodShop.Persistance.Database;
using Microsoft.AspNetCore.Mvc;

namespace FoodShop.Server.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BonusCardController(ApplicationDbContext dbContext, IBonusCardService bonusCardService) : ControllerBase
{

    [HttpPost]
    public async Task<IActionResult> CreateBonusCard()
    {
        bonusCardService.Create();
        return Ok();
    }

    [HttpPost("amount")]
    public async Task<IActionResult> AddBonus(int amount)
    {
        bonusCardService.CreateBonuses(amount);
        dbContext.SaveChanges();
        return Ok();
    }

    [HttpPut("cancellation")]
    public async Task<IActionResult> Cancellation(int amount)
    {
        try
        {
            bonusCardService.Cancellation(amount);
            dbContext.SaveChanges();
            return Ok();
        }
        catch (Exception)
        {

            return BadRequest("Ошибка, недостаточно бонусов");
        }
       
    }
}
