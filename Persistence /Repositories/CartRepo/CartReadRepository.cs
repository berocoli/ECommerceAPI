using System;
using System.Collections.Generic;
using System.Data;
using System.Text.Json;
using System.Threading.Tasks;
using Application.Exceptions;
using Application.Repositories;
using Domain;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class CartReadRepository : ReadRepository<Cart>, ICartReadRepository
    {
        private readonly ECommerceAPIDbContext _context;

        public CartReadRepository(ECommerceAPIDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Cart>> GetCartsByIdAsyncSP(string userId)
        {
            await using var connection = (NpgsqlConnection)_context.Database.GetDbConnection();
            await connection.OpenAsync();

            await using var command = connection.CreateCommand();
            command.CommandText = "CALL public.get_carts(@_cart)";
            command.CommandType = CommandType.Text;

            // Use parameter name that matches the SP parameter '_cart'
            var parameter = new NpgsqlParameter("_cart", NpgsqlTypes.NpgsqlDbType.Json)
            {
                Direction = ParameterDirection.InputOutput,
                Value = JsonSerializer.Serialize(new { UserId = userId })
            };

            command.Parameters.Add(parameter);

            await command.ExecuteNonQueryAsync();

            var resultJson = parameter.Value?.ToString();
            Console.WriteLine("Raw JSON from SP: " + resultJson); // Debugging

            if (string.IsNullOrWhiteSpace(resultJson))
            {
                throw new GetRequestFailedException("The user doesn't have a cart.");
            }

            try
            {
                var carts = JsonSerializer.Deserialize<List<Cart>>(resultJson, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                if (carts == null)
                {
                    // If deserialization returns null, throw an exception
                    throw new GetRequestFailedException("Failed to deserialize the cart data.");
                }

                return carts;
            }
            catch (JsonException ex)
            {
                throw new GetRequestFailedException("Failed to deserialize the cart data.", ex);
            }
        }
    }
}
