using FoodShop.Application.DTO;
using FoodShop.Application.DTO.Responces;

namespace FoodShop.Application.Interfaces.Identity;
public interface ILoginService
{
    public Task<LoginResponce> LoginUserAsync(UserLoginModelDto loginModelDto);
}
