using AppService.Application.Interfaces;
using AppService.Application.Services;

using Microsoft.Extensions.DependencyInjection;

namespace AppService.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IDataSourceService, DataSourceService>();
            services.AddScoped<IBlobService, BlobService>();

            return services;
        }
    }
}
