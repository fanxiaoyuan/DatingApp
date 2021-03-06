using System.Threading.Tasks;
using DatingApp.API.Model;

namespace DatingApp.API.Data
{
    public interface IAuthRepository
    {
         Task<User> RegisterAsync(User user, string password);
         Task<User> LoginAsync(string username, string password);
         Task<bool> UserExistsAsync(string username);
    }
}