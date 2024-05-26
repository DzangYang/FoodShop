﻿using System.ComponentModel.DataAnnotations;

namespace FoodShop.Application.DTO;
public class UserLoginModelDto
{
    [Required]
    public string Login { get; set; }

    [Required, Compare(nameof(Password))]
    public string Password { get; set; }
}
