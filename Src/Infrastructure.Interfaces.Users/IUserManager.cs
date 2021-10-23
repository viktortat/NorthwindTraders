using System.Threading.Tasks;
using Northwind.Utils;

namespace Infrastructure.Interfaces.Users
{
    public interface IUserManager
    {
        Task<(Result Result, string UserId)> CreateUserAsync(string userName, string password);

        Task<Result> DeleteUserAsync(string userId);
    }
}
