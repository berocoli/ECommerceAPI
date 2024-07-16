using System;
using System.Linq.Expressions;
using Application.Repositories;
using Domain;
using Microsoft.EntityFrameworkCore;
using Persistance.Contexts;

namespace Persistance.Repositories
{
    public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository
    {
        public CustomerReadRepository(ECommerceAPIDbContext context) : base(context)
        {
        }
    }
}

