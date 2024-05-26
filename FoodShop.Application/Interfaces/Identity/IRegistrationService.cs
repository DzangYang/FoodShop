using FoodShop.Application.DTO;
using FoodShop.Application.DTO.Responces;


namespace FoodShop.Application.Interfaces.Identity;
public interface IRegistrationService
{
    Task<RegistrationResponce> RegistrationUserAsync(UserRegistrationModelDto registrationModelDto);
}
