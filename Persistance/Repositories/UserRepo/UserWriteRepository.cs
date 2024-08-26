using System;
using Application.Repositories;
using Persistance.Contexts;
using Domain;

namespace Persistance.Repositories.UserRepo
{
    public class UserWriteRepository : WriteRepository<User>, IUserWriteRepository
    {
        public UserWriteRepository(ECommerceAPIDbContext context) : base(context)
        {
        }
    }
}

