using Application.DTOs;

namespace Application.Services
{
    public interface IUserService
    {
        Task<List<UserDto>> GetAllUsersAsync();
        Task<UserDto> GetUserByIdAsync(string id);
        Task<List<UserDto>> SearchUsersByNameAsync(string name);
        Task<bool> CreateUserAsync(CreateUserDto UserDto);
        Task<bool> UpdateUserAsync(UpdateUserDto UserDto);
        Task<bool> DeleteUserAsync(string id);
    }
}
