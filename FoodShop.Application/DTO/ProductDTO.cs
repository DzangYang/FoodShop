using FoodShop.Domain.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShop.Application.DTO;
public class ProductDTO
{
    public Guid Id { get; set; }
    /// <summary>
    /// Наименование товара
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Стоимость товара
    /// </summary>
    public decimal Price { get; set; }

    /// <summary>
    /// Фото товара
    /// </summary>
    public string ImageURL { get; set; }

    /// <summary>
    /// Список продаж товара
    /// </summary>
   
    public string CategoryName { get; set; }
    public string CategoryId { get; set; }
}
