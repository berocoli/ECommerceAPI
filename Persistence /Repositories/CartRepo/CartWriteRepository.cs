using System;
using Application.Repositories;
using Domain;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class CartWriteRepository : WriteRepository<Cart>, ICartWriteRepository
    {
        public CartWriteRepository(ECommerceAPIDbContext context) : base(context)
        {
        }
    }
}

