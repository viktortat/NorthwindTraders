using System.Reflection;
using Infrastructure.Interfaces.Csv;
using Microsoft.Extensions.DependencyInjection;
using Northwind.Infrastructure.Files;

namespace Northwind.UseCases
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureCsv(this IServiceCollection services)
        {
            services.AddTransient<ICsvFileBuilder, CsvFileBuilder>();
            return services;
        }
    }
}
