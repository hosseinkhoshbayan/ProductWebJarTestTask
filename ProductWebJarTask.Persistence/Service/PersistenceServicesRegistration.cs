using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProductWebJarTask.Application.Contracts.Persistence;
using ProductWebJarTask.Persistence.Context;
using ProductWebJarTask.Persistence.Repositories;

namespace ProductWebJarTask.Persistence.Service;

public static class PersistenceServicesRegistration
{
    public static IServiceCollection ConfigurePersistenceServices(this IServiceCollection services
        , IConfiguration configuration)
    {
        services.AddDbContext<EShopWebjarTestTaskDbContext>(options =>
        {
            options.UseSqlServer(configuration
                .GetConnectionString("EShopWebJarTestTaskDbConnection"));
        });
        services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));


        return services;
    }
}
}