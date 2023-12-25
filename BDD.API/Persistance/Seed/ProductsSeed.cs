using BDD.API.Models;
using Microsoft.EntityFrameworkCore;

namespace BDD.API.Persistance.Seed
{
    public static class ProductsSeed
    {
        public static void AddProducts(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasData(
                new Product
                {
                    Id = 1,
                    Name = "Prod1",
                    Price = 100
                });

            modelBuilder.Entity<Product>()
                .HasData(
                new Product
                {
                    Id = 2,
                    Name = "Prod2",
                    Price = 200
                });


            modelBuilder.Entity<Product>()
                .HasData(
                new Product
                {
                    Id = 3,
                    Name = "Prod3",
                    Price = 300
                });

            modelBuilder.Entity<Product>()
                .HasData(
                new Product
                {
                    Id = 4,
                    Name = "Prod4",
                    Price = 400
                });
        }
    }
}