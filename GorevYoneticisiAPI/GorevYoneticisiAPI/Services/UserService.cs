using GorevYoneticisiAPI.Dtos;
using GorevYoneticisiAPI.Models;
using GorevYoneticisiAPI.Repositories;

namespace GorevYoneticisiAPI.Services
{
    public class UserService : IUserService
    {
        private readonly IGenericRepository<User> _genericRepository;
        public UserService(IGenericRepository<User> genericRepository) { 
            _genericRepository = genericRepository;
        }

        public async Task<User> AddUserAsync(User user)
        {
            await _genericRepository.AddAsync(user);
            return user;
        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            return _genericRepository.GetAll().ToList();
        }

        public async Task<User> GetUserByIdAsync(int userId)
        {
            return await _genericRepository.GetByIdAsync(userId);
        }

        public async Task<bool> LoginCheckAsync(User user)
        {
            throw new NotImplementedException();
        }

        public async System.Threading.Tasks.Task RemoveUserByIdAsync(int userId)
        {
            var user = await _genericRepository.GetByIdAsync(userId);
            _genericRepository.Remove(user);
        }

        public async Task<User> UpdateUserByIdAsync(User user)
        {
            _genericRepository.Update(user);
            return user;
        }
    }
}
