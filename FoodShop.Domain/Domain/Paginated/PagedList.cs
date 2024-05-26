using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShop.Domain.Domain.Paginated;
public class PagedList<T>
{
    public PagedList()
    {
    }

    public PagedList(IList<T> items, int pageNumber, int pageSize, int totalCount)
    {
        Items = items;
        PageNumber = pageNumber;
        PageSize = pageSize;
        TotalCount = totalCount;
    }

    public IList<T> Items { get; init; }
    /// <summary>
    /// Размер страницы
    /// </summary>
    public int PageSize { get; }
    /// <summary>
    /// Номер страницы
    /// </summary>
    public int PageNumber { get; }
    /// <summary>
    /// Общее число элементов
    /// </summary>
    public int TotalCount { get; }
    /// <summary>
    /// Есть следующая страница
    /// </summary>
    public bool HasNextPage => PageNumber * PageSize < TotalCount;
    /// <summary>
    /// Есть предыдущая страница
    /// </summary>
    public bool HasPreviousPage => PageSize > 1;


}
