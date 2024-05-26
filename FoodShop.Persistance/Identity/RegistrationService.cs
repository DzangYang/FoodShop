using FoodShop.Application.DTO;
using FoodShop.Application.DTO.Responces;
using FoodShop.Application.Interfaces.Identity;
using FoodShop.Domain.Domain.Entities;
using FoodShop.Persistance.Database;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace FoodShop.Persistance.Identity;
public class RegistrationService(ApplicationDbContext dbContext, UserManager<ApplicationUser> _userManager) : IRegistrationService
{

    //Регистрация пользователя
    public async Task<RegistrationResponce> RegistrationUserAsync(UserRegistrationModelDto registrationModelDto)
    {
        var findUser = await dbContext.Users.FirstOrDefaultAsync(u => u.Login == registrationModelDto.Login);
        if (findUser != null) return new RegistrationResponce(false, "Пользователь уже существует");

        var user = new ApplicationUser
        {
            Login = registrationModelDto.Login,
            Password = registrationModelDto.Password,
            UserName = registrationModelDto.Login,
        };

        var result = _userManager.CreateAsync(user, registrationModelDto.Password).Result;
        return new RegistrationResponce(true, "Регистрация пользователя прошла успешно");
    }

}
