using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace ProductWebJarTask.Application.AppService;

public static class ApplicationServicesRegistration
{
    public static void ConfigureApplicationServices(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddMediatR(Assembly.GetExecutingAssembly());
    }
}