using Domain;
namespace Application.Repositories
{
    public interface IUserReadRepository : IReadRepository<User>
    {
        Task<User> GetUserByEmailAsync(string email, bool tracking = true);
    }
}

