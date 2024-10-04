using System;
using Application.Repositories.CartRepo;
using Domain;
using Persistence.Contexts;

namespace Persistence.Repositories.CartRepo
{ 
    public class CartReadRepository : ReadRepository<Cart>, ICartReadRepository
    {
        public CartReadRepository(ECommerceAPIDbContext context) : base(context)
        {
        }
    }
}

