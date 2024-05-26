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
    public void Create(CreateWalletDTO createWalletDTO)
    {
        walletService.Create(createWalletDTO);

    }

    [HttpPost("amount")]
    public void Decreese(int amount)
    {
        walletService.Cancellation(amount);
        dbContext.SaveChanges();
    }
}
