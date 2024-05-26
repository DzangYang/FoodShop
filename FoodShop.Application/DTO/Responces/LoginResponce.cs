using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShop.Application.DTO.Responces;
public record LoginResponce(bool Flag, string Message = null!, string Token = null!);

