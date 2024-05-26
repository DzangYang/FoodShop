using FoodShop.Application.DTO;
using FoodShop.Application.Interfaces.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FoodShop.Server.Controllers;
[Route("api/[controller]")]
[ApiController]
public class UserController(IRegistrationService registrationService, ILoginService loginService) : ControllerBase
{

    /// <summary>
    /// Авторизация пользователя
    /// </summary>
    /// <param name="loginModelDto">Данные для авторизации пользователя</param>
    /// <returns></returns>
    [HttpPost("login")]
    public async Task<IActionResult> LogUserIn(UserLoginModelDto loginModelDto)
    {
        var res = await loginService.LoginUserAsync(loginModelDto);
        return Ok(res);
    }


    /// <summary>
    /// Регистрация пользователя
    /// </summary>
    /// <param name="registrationModelDto">Данные для регистрации пользователя</param>
    /// <returns></returns>
    [HttpPost("register")]
    public async Task<IActionResult> RegisterUser([FromQuery] UserRegistrationModelDto registrationModelDto)
    {
        var result = await registrationService.RegistrationUserAsync(registrationModelDto);
        return Ok(result);
    }

}
