using System;
using Application.Repositories;
using Domain;
using Persistance.Contexts;

namespace Persistance.Repositories
{
    public class OrderWriteRepository : WriteRepository<Order>, IOrderWriteRepository
    {
        public OrderWriteRepository(ECommerceAPIDbContext context) : base(context)
        {
        }
    }
}

