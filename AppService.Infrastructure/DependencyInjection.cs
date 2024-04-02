using AppService.Application.Common.Interfaces;
using AppService.Infrastructure.Blobs.Persistence;
using AppService.Infrastructure.Common.Persistence;
using AppService.Infrastructure.DataSources.Persistence;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AppService.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });
            services.AddScoped<IDataSourceRepositrory, DataSourceRepository>();
            services.AddScoped<IBlobRepository, BlobRepository>();

            return services;
        }
    }
}
