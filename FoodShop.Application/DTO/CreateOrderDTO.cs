﻿using FoodShop.Domain.Domain.Entities;

namespace FoodShop.Application.DTO;
public class CreateOrderDTO
{
    public WayOfPayment Payment { get; set; }

    public IList<CreateOrderSaleDTO> Sales { get; set; }
}
