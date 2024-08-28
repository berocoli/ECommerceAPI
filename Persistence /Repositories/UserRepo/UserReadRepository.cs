using Application.Repositories;
using Domain;
using Persistence.Contexts;
using Persistence.Repositories;

namespace Persistence.Repositories.UserRepo
{
    public class UserReadRepository : ReadRepository<User>, IUserReadRepository
    {
        public UserReadRepository(ECommerceAPIDbContext context) : base(context)
        {
        }
    }
}

