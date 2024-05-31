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
        var result = await loginService.LoginUserAsync(loginModelDto);

        return result != null ? Ok(result) : NotFound();
    }


    /// <summary>
    /// Регистрация пользователя
    /// </summary>
    /// <param name="registrationModelDto">Данные для регистрации пользователя</param>
    /// <returns></returns>
    [HttpPost("register")]
    public async Task<IActionResult> RegisterUser( UserRegistrationModelDto registrationModelDto)
    {
        var result = await registrationService.RegistrationUserAsync(registrationModelDto);

        return result != null ? Ok(result) : NotFound();
    }

}
