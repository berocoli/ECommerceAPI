using System;
using Application.Repositories;
using Domain;
using Persistance.Contexts;

namespace Persistance.Repositories
{
    public class OrderReadRepository : ReadRepository<Order>, IOrderReadRepository
    {
        public OrderReadRepository(ECommerceAPIDbContext context) : base(context)
        {
        }
    }
}

