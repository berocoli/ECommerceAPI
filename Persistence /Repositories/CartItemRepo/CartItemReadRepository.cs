using System;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class CartItemReadRepository : ReadRepository<CartItem>, ICartItemReadRepository
    {
        public CartItemReadRepository(ECommerceAPIDbContext context) : base(context)
        {
        }
    }
}

