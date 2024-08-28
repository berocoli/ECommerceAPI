using System;
using Application.Repositories;
using Application.Repositories.User;
using Domain;
using Persistance.Contexts;

namespace Persistance.Repositories
{
    public class UserWriteRepository : WriteRepository<User>, IUserWriteRepository
    {
        public UserWriteRepository(ECommerceAPIDbContext context) : base(context)
        {
        }
    }
}

