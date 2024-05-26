using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShop.Application.Services.CashPaymentService;
public interface ICashPaymentService
{
    Task Cancellation(int amount);
}
