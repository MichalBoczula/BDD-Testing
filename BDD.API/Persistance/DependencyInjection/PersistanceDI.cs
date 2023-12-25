using BDD.API.Persistance.Abstract;
using BDD.API.Persistance.Context;
using BDD.API.Persistance.Repository;
using Microsoft.EntityFrameworkCore;

namespace BDD.API.Persistance.DependencyInjection
{
    public static class PersistanceDI
    {
        public static IServiceCollection AddPersistance(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BddContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("Default")));

            services.AddTransient<IProductsRepository, ProductsRepository>();
            services.AddTransient<IOrdersRepository, OrdersRepository>();
            return services;
        }
    }
}
