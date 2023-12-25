using BDD.API.Models;
using BDD.API.Persistance.Seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace BDD.API.Persistance.Context
{
    public class BddContext : DbContext
    {
        public BddContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.AddProducts();
            modelBuilder.AddOrders();
            modelBuilder.AddOrderedProducts();
        }
    }
}
