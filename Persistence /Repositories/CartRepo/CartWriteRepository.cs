using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Application.Repositories;
using Domain;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Npgsql;
using NpgsqlTypes;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class CartWriteRepository : WriteRepository<Cart>, ICartWriteRepository
    {
        private readonly ECommerceAPIDbContext _context;
        public CartWriteRepository(ECommerceAPIDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Cart>> CreateCartsForUsers(string? userId)
        {
            await using var connection = _context.Database.GetDbConnection();
            await connection.OpenAsync();

            await using var command = connection.CreateCommand();
            command.CommandText = "CALL public.create_product(_userId => @user_id, created_user_ids => @created_user_ids);";
            command.CommandType = CommandType.Text;

            // Set up the _userId parameter
            var userIdParameter = new NpgsqlParameter("user_id", NpgsqlDbType.Uuid)
            {
                Direction = ParameterDirection.InputOutput,
                Value = !string.IsNullOrEmpty(userId) ? (object)Guid.Parse(userId) : DBNull.Value
            };

            // Set up the created_user_ids parameter
            var createdUserIdsParameter = new NpgsqlParameter("created_user_ids", NpgsqlDbType.Json)
            {
                Direction = ParameterDirection.InputOutput,
                Value = DBNull.Value // Initialize to NULL
            };

            command.Parameters.Add(userIdParameter);
            command.Parameters.Add(createdUserIdsParameter);

            await command.ExecuteNonQueryAsync();

            // Retrieve the output parameter
            var createdUserIdsJson = createdUserIdsParameter.Value?.ToString();

            List<Guid> createdUserIds = new List<Guid>();

            if (!string.IsNullOrEmpty(createdUserIdsJson) && createdUserIdsJson != "null")
            {
                try
                {
                    createdUserIds = JsonConvert.DeserializeObject<List<Guid>>(createdUserIdsJson) ?? new List<Guid>();
                }
                catch (JsonException ex)
                {
                    // Handle JSON deserialization error
                    // Log the exception as needed
                    throw new Exception("Failed to deserialize created_user_ids JSON.", ex);
                }
            }

            List<Cart> createdCarts = new List<Cart>();

            if (createdUserIds.Count > 0)
            {
                // Fetch the carts from the database using Entity Framework
                createdCarts = await _context.Carts
                    .Where(c => createdUserIds.Contains(c.UserId) && c.IsModifyable)
                    .ToListAsync();
            }

            return createdCarts;
        }
    }
}
