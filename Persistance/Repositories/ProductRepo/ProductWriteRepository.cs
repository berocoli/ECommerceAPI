using System;
using Application.Repositories;
using Domain;
using Persistance.Contexts;

namespace Persistance.Repositories
{
    public class ProductWriteRepository : WriteRepository<Product>, IProductWriteRepository
    {
        public ProductWriteRepository(ECommerceAPIDbContext context) : base(context)
        {
        }
    }
}

