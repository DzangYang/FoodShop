using FoodShop.Domain.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodShop.Persistance.EntityTypeConfigurations;
public class MerchandiseShopConfiguration : IEntityTypeConfiguration<Order>, IEntityTypeConfiguration<Sale>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.HasKey(order => order.Id);
        builder.HasIndex(order => order.Id).IsUnique();

    }

    public void Configure(EntityTypeBuilder<Sale> builder)
    {
        builder.HasKey(order => order.Id);
        builder.HasIndex(order => order.Id).IsUnique();
    }

}
