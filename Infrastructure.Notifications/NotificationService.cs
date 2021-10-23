using System.Threading.Tasks;
using Infrastructure.Interfaces.Notifications;

namespace Northwind.Infrastructure
{
    public class NotificationService : INotificationService
    {
        public Task SendAsync(MessageDto message)
        {
            return Task.CompletedTask;
        }
    }
}
