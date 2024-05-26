using FoodShop.Application.DTO;
using FoodShop.Application.DTO.Responces;
using FoodShop.Application.Interfaces.Identity;
using FoodShop.Domain.Domain.Entities;
using FoodShop.Persistance.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;


namespace FoodShop.Persistance.Identity;
public class LoginService(ApplicationDbContext dbContext, IConfiguration configuration) : ILoginService
{


    async Task<LoginResponce> ILoginService.LoginUserAsync(UserLoginModelDto loginModelDto)
    {
        var findUser = await dbContext.Users.FirstOrDefaultAsync(u => u.Login == loginModelDto.Login);
        if (findUser == null) return new LoginResponce(false, "Пользователь не найден");

        return new LoginResponce(true, "Аутенфикация прошла успешно", GenerateJWTToken(findUser));
    }

    private string GenerateJWTToken(ApplicationUser findUser)
    {
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]));
        var credintials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
        var userClaims = new[]
        {
            new Claim(ClaimTypes.NameIdentifier, findUser.Id.ToString()),
            new Claim(ClaimTypes.Name, findUser.UserName!),

        };
        var token = new JwtSecurityToken(
            issuer: configuration["Jwt:Issuer"],
            audience: configuration["Jwt:Audience"],
            claims: userClaims,
            expires: DateTime.Now.AddDays(5),
            signingCredentials: credintials
            );
        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}
