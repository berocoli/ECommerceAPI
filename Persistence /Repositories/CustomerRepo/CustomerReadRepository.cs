using System;
using System.Linq.Expressions;
using Application.Repositories;
using Domain;
using Microsoft.EntityFrameworkCore;
using Persistance.Contexts;

namespace Persistance.Repositories
{
    public class UserReadRepository : ReadRepository<User>, IUserReadRepository
    {
        public UserReadRepository(ECommerceAPIDbContext context) : base(context)
        {
        }
    }
}

