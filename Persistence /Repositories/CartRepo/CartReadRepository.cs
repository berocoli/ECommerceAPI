using System;
using System.Data;
using System.Text.Json;
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
            await using var connection = _context.Database.GetDbConnection();
            await connection.OpenAsync();

            var command = connection.CreateCommand();
            command.CommandText = "CALL public.get_carts(@cart_filter)";
            command.CommandType = CommandType.Text;

            var parameter = new NpgsqlParameter("cart_filter", NpgsqlTypes.NpgsqlDbType.Json)
            {
                Direction = ParameterDirection.InputOutput,
                Value = JsonSerializer.Serialize(new { UserId = userId })
            };

            command.Parameters.Add(parameter);

            await command.ExecuteNonQueryAsync();

            var resultJson = parameter.Value.ToString();

            if (string.IsNullOrEmpty(resultJson))
            {
                return new List<Cart>();
            }
            
            return JsonSerializer.Deserialize<List<Cart>>(resultJson);
        }
    }
}

