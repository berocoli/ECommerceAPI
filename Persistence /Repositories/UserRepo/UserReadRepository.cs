using Application.Repositories;
using Domain;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;
using Persistence.Repositories;

namespace Persistence.Repositories.UserRepo
{
    public class UserReadRepository : ReadRepository<User>, IUserReadRepository
    {
        private readonly ECommerceAPIDbContext _context;
        public UserReadRepository(ECommerceAPIDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<User> GetUserByEmailAsync(string email, bool tracking = true)
        {
            var query = Table.AsQueryable();
            if(tracking == true)
                query = Table.AsNoTracking();
            return await Table.FirstOrDefaultAsync(u => u.Email == email);
        }
    }
}

