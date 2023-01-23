using Alphastellar.Case.BusinessLayer.Manager;
using Alphastellar.Case.CoreLayer.Interfaces.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Alphastellar.Case.BusinessLayer
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ICarService, CarManager>();
            services.AddScoped<IBusService, BusManager>();
            services.AddScoped<IBoatService, BoatManager>();

            return services;
        }
    }
}
