using FoodShop.Domain.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShop.Application.DTO;
public class OrderDTO
{
    


    public WayOfPayment Payment { get; set; }


  


    public IList<CreateOrderSaleDTO> Sales { get; set; }
}
