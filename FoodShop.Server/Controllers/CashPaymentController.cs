    using FoodShop.Application.Services.CashPaymentService;
    using Microsoft.AspNetCore.Mvc;

    namespace FoodShop.Server.Controllers;
    [Route("api/[controller]")]
    [ApiController]
    public class CashPaymentController(ICashPaymentService cashPaymentService) : ControllerBase
    {


        [HttpPut("amount")]
        public async Task<ActionResult> Decreese(int amount)
        {
            if (amount <= 0)
                return BadRequest();
            try
            {
                await cashPaymentService.Cancellation(amount);
                return Ok();
            }
            catch (Exception)
            {

                return BadRequest("Ошибка недостаточно средств в кошельке");
            }
       
        }

    }
