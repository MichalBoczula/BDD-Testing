using BDD.API.Persistance.Context;
using Microsoft.EntityFrameworkCore;

namespace BDD.API.Persistance.DependencyInjection
{
    public static class PersistanceDI
    {
        public static IServiceCollection AddPersistance(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BddContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("Default")));
            return services;
        }
    }
}
