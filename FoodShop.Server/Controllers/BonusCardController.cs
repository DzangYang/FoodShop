using FoodShop.Application.Services.BonusCardService;
using FoodShop.Persistance.Database;
using Microsoft.AspNetCore.Mvc;

namespace FoodShop.Server.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BonusCardController(ApplicationDbContext dbContext, IBonusCardService bonusCardService) : ControllerBase
{

    [HttpPost]
    public void CreateBonusCard()
    {
        bonusCardService.Create();
    }

    [HttpPost("amount")]
    public void AddBonus(int amount)
    {
        bonusCardService.CreateBonuses(amount);
        dbContext.SaveChanges();
    }
}
