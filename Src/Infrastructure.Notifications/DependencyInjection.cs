using Infrastructure.Interfaces.Notifications;
using Microsoft.Extensions.DependencyInjection;
using Northwind.Infrastructure;

namespace Northwind.UseCases
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddNotifications(this IServiceCollection services)
        {
            services.AddTransient<INotificationService, NotificationService>();

            return services;
        }
    }
}
