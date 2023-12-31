using BDD.API.Persistance.Context;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BDD.AcceptanceTests.Configuration
{
    public class WebAppFactory<TEntryPoint> : WebApplicationFactory<Program> where TEntryPoint : Program
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureServices(services =>
            {
                var descriptor = services.SingleOrDefault(
                    d => d.ServiceType ==
                        typeof(DbContextOptions<BddContext>));

                if (descriptor != null)
                    services.Remove(descriptor);

                services.AddDbContext<BddContext>(options =>
                {
                    options.UseSqlServer("Server=localhost;Database=BDD-Acceptance-Tests;Trusted_Connection=True;TrustServerCertificate=True;Encrypt=false;");
                });

                var sp = services.BuildServiceProvider();

                using (var scope = sp.CreateScope())

                using (var appContext = scope.ServiceProvider.GetRequiredService<BddContext>())
                {
                    try
                    {
                        appContext.Database.EnsureDeleted();
                        appContext.Database.EnsureCreated();
                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
                }
            });
        }
    }
}
