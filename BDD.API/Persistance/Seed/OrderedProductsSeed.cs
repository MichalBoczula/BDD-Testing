using BDD.API.Models;
using Microsoft.EntityFrameworkCore;

namespace BDD.API.Persistance.Seed
{
    public static class OrderedProductsSeed
    {
        public static void AddOrderedProducts(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderedProducts>()
                .HasData(
                new OrderedProducts
                {
                    Id = 1,
                    OrderId= 1,
                    ProductId= 1,
                });
            modelBuilder.Entity<OrderedProducts>()
                .HasData(
                new OrderedProducts
                {
                    Id = 2,
                    OrderId = 1,
                    ProductId = 2,
                });

            modelBuilder.Entity<OrderedProducts>()
                .HasData(
                new OrderedProducts
                {
                    Id = 3,
                    OrderId = 2,
                    ProductId = 1,
                });
            modelBuilder.Entity<OrderedProducts>()
                .HasData(
                new OrderedProducts
                {
                    Id = 4,
                    OrderId = 2,
                    ProductId = 2,
                });
            modelBuilder.Entity<OrderedProducts>()
                .HasData(
                new OrderedProducts
                {
                    Id = 5,
                    OrderId = 2,
                    ProductId = 3,
                });

            modelBuilder.Entity<OrderedProducts>()
                .HasData(
                new OrderedProducts
                {
                    Id = 6,
                    OrderId = 3,
                    ProductId = 3,
                });
            modelBuilder.Entity<OrderedProducts>()
                .HasData(
                new OrderedProducts
                {
                    Id = 7,
                    OrderId = 3,
                    ProductId = 4,
                });
        }
    }
}
