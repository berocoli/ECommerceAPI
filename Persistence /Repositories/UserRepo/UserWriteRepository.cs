using Application.Repositories;
using Domain;
using Persistence.Contexts;
using Persistence.Repositories;

namespace Persistence.Repositories.UserRepo
{
    public class UserWriteRepository : WriteRepository<User>, IUserWriteRepository
    {
        public UserWriteRepository(ECommerceAPIDbContext context) : base(context)
        {
        }
    }
}

