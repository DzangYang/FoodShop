using FoodShop.Application.Services.BonusCardService;
using FoodShop.Domain.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace FoodShop.Application.Interfaces.Identity;
public class CurrentUserService : ICurrentUserService
{
    public CurrentUserService(IHttpContextAccessor httpContextAccessor, UserManager<ApplicationUser> _userManager)
    {

        var userId = httpContextAccessor.HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier);
        Id = Guid.Parse(userId.Value);
    }
    public Guid Id { get; set; }
}
