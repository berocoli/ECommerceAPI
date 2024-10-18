using System;
using Application.Repositories;
using Domain;
using Persistence.Contexts;

namespace Persistence.Repositories
{ 
    public class CartReadRepository : ReadRepository<Cart>, ICartReadRepository
    {
        public CartReadRepository(ECommerceAPIDbContext context) : base(context)
        {
        }
    }
}

