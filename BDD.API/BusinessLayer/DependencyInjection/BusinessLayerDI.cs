using BDD.API.BusinessLayer.Abstract;
using BDD.API.BusinessLayer.Managers;
using System.Reflection;

namespace BDD.API.BusinessLayer.DependencyInjection
{
    public static class BusinessLayerDI
    {
        public static IServiceCollection AddBusinessLayer(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddTransient<IOrderManager, OrderManager>();
            services.AddTransient<IProductsManager, ProductsManager>();
            return services;
        }
    }
}