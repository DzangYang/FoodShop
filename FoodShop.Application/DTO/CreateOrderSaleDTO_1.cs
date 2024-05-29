using FoodShop.Domain.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShop.Application.DTO;
public class CreateOrderSaleDTO
{
   public Guid Id { get; set; }
 
    public Guid ProductId { get; set; }

    
    public int Qantity { get; set; }

    public decimal TotalPrice { get; set; }
}
