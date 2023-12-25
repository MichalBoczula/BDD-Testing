using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using BDD.API.Models;

namespace BDD.API.Persistance.Configuration
{
    public class OrderedProductsConfiguration : IEntityTypeConfiguration<OrderedProducts>
    {
        public void Configure(EntityTypeBuilder<OrderedProducts> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.OrderRef)
                .WithMany(x => x.OrderedProductsList)
                .HasForeignKey(x => x.OrderId);
            builder.HasOne(x => x.ProductRef)
                .WithMany(x => x.OrderedProductsList)
                .HasForeignKey(x => x.ProductId);
        }
    }
}
