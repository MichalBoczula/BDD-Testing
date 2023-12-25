using BDD.API.Models;
using Microsoft.EntityFrameworkCore;

namespace BDD.API.Persistance.Seed
{
    public static class OrderSeed
    {
        public static void AddOrders(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .HasData(
                new Order
                {
                    Id = 1,
                    Identifier = Guid.NewGuid(),
                    Name = "Order1",
                });

            modelBuilder.Entity<Order>()
                .HasData(
                new Order
                {
                    Id = 2,
                    Identifier = Guid.NewGuid(),
                    Name = "Order2",
                });

            modelBuilder.Entity<Order>()
                .HasData(
                new Order
                {
                    Id = 3,
                    Identifier = Guid.NewGuid(),
                    Name = "Order2",
                });
        }
    }
}
