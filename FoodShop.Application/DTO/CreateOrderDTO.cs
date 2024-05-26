using FoodShop.Domain.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShop.Application.DTO;
public class CreateOrderDTO
{
 
    public Guid UserId { get; set; }

  
    public WayOfPayment Payment { get; set; }

   
    public DateTime CreateDate { get; set; }

  
    public IList<Sale>? Sales { get; set; }
}
