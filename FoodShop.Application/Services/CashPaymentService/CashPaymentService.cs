﻿using FoodShop.Application.Services.BonusCardService;
using FoodShop.Domain.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace FoodShop.Application.Services.CashPaymentService;
public class CashPaymentService(ICurrentUserService currentUserService, UserManager<ApplicationUser> _userManager) : ICashPaymentService
{
    public async Task Cancellation(int amount)
    {
        var user = await _userManager.Users.FirstOrDefaultAsync(u => u.Id == currentUserService.Id);
        user.Cash -= amount;
        await _userManager.UpdateAsync(user);

    }
}