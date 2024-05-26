using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShop.Application.DTO;
public class CreateWalletDTO
{

    public Guid UserId { get; set; }


    public string HolderName { get; set; }


    public string Number { get; set; }


    public string CVV { get; set; }


    public DateTime ExpiryDate { get; set; }



}
