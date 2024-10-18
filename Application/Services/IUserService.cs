using Application.DTOs;

namespace Application.Services
{
    public interface IUserService
    {
        Task<List<UserDto>> GetAllUsersAsync();
        Task<UserDto> GetUserByIdAsync(string id);
        Task<List<UserDto>> SearchUsersByNameAsync(string name, string surname);
        Task<bool> CreateUserAsync(string name, string surname, string email, string password);
        Task<bool> UpdateUserAsync(string id, string name, string surname, string email, string password, bool role);
        Task<bool> DeleteUserAsync(string id);
    }
}
