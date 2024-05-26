using FoodShop.Application.DTO;
using FoodShop.Application.DTO.Responces;
using FoodShop.Application.Interfaces.Identity;
using System.Net.Http.Json;

namespace FoodShop.Application.Services.Identity;
public class AccountService(HttpClient httpClient) : IRegistrationService, ILoginService
{
    public async Task<LoginResponce> LoginUserAsync(UserLoginModelDto loginModelDto)
    {
        var response = await httpClient.PostAsJsonAsync("api/user/login", loginModelDto);

        var result = await response.Content.ReadFromJsonAsync<LoginResponce>();
        return result!;
    }

    public async Task<RegistrationResponce> RegistrationUserAsync(UserRegistrationModelDto registrationModelDto)
    {
        var response = await httpClient.PostAsJsonAsync("api/user/register", registrationModelDto);

        var result = await response.Content.ReadFromJsonAsync<RegistrationResponce>();
        return result!;
    }
}
