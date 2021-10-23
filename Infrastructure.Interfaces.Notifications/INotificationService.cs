using System.Threading.Tasks;

namespace Infrastructure.Interfaces.Notifications
{
    public interface INotificationService
    {
        Task SendAsync(MessageDto message);
    }
}
