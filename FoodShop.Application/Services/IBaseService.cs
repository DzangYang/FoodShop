using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShop.Application.Services;
public interface IBaseService<TEntity, TDto>
{
    /// <summary>
    /// Получить по айди
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    TDto GetById(Guid id);

}
