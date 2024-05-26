using FoodShop.Domain.Domain.Paginated;
using Microsoft.EntityFrameworkCore.Query;

namespace FoodShop.Persistance.Repository.Paginated;
public static class PagedListExtensision
{
    public static PagedList<Tdto> ToPagedList<Tdto>(this List<Tdto> query, int pageNumber, int pageSize)
    {
        int totalCount = query.Count();

        var items = query.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();

        return new PagedList<Tdto>(items, pageNumber, pageSize, totalCount);
    }
}
