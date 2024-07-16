using System;
using Application.Repositories;
using Domain;
using Persistance.Contexts;

namespace Persistance.Repositories
{
    public class CustomerWriteRepository : WriteRepository<Customer>, ICustomerWriteRepository
    {
        public CustomerWriteRepository(ECommerceAPIDbContext context) : base(context)
        {
        }
    }
}

