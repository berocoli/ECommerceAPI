using System;
using System.Data;
using Application.Repositories;
using Domain;
using Microsoft.EntityFrameworkCore;
using Persistance.Contexts;

namespace Persistance.Repositories
{
    public class ProductReadRepository : ReadRepository<Product>, IProductReadRepository
    {
        private readonly ECommerceAPIDbContext _context;
        public ProductReadRepository(ECommerceAPIDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Product>> GetFromStoredProcedureAsync(bool tracking = true)
        {
            var Products = new List<Product>();
            var commandText = "SELECT * FROM get_all_products2();";

            using (var command = _context.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = commandText;
                command.CommandType = CommandType.Text;

                _context.Database.OpenConnection();

                using (var result = await command.ExecuteReaderAsync())
                {
                    while(await result.ReadAsync())
                    {
                        var product = new Product
                        {
                            Id = result.GetGuid(0),
                            Name = result.GetString(1),
                            Price = result.GetDouble(2),
                            Stock = result.GetDouble(3),
                            Description = result.IsDBNull(4) ? null : result.GetString(4),
                            ImageUrl = result.GetString(5)
                        };

                        Products.Add(product);
                    }
                }
                _context.Database.CloseConnection();
            }
            return Products;
        }
    }
}

