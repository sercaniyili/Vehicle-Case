using Alphastellar.Case.CoreLayer.Interfaces.Repositories;
using Alphastellar.Case.DataAccessLayer.Context;
using Alphastellar.Case.DataAccessLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alphastellar.Case.DataAccessLayer
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddDALServices(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));

            });

            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddScoped<ICarRepository, CarRepository>();
            services.AddScoped<IBusRepository, BusRepository>();
            services.AddScoped<IBoatRepository, BoatRepository>();
            return services;
        }

    }
}
