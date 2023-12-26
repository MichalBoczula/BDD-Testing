using BDD.API.Persistance.Abstract;
using BDD.API.Persistance.Context;
using BDD.API.Persistance.Repository;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace BDD.API.Mapping.DependencyInjection
{
    public static class MappingDI
    {
        public static IServiceCollection AddMapping(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
