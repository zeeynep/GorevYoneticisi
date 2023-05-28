using GorevYoneticisiAPI.Dtos;
using GorevYoneticisiAPI.Models;

namespace GorevYoneticisiAPI.Services
{
    public interface IUserService
    {
        Task<User> GetUserByIdAsync(int userId);
        System.Threading.Tasks.Task RemoveUserByIdAsync(int userId);
        Task<User> UpdateUserByIdAsync(User user);
        Task<User> AddUserAsync(User user);
        [Obsolete]
        Task<bool> LoginCheckAsync(User user);
        Task<List<User>> GetAllUsersAsync();
    }
}
