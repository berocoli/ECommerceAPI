using System.Data;
using Application.Repositories;
using Domain;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Persistence.Contexts;


namespace Persistence.Repositories
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
            var commandText = "SELECT * FROM get_all_products();";

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
                            CategoryId = result.GetGuid(1),
                            Name = result.GetString(2),
                            Price = result.GetDouble(3),
                            Stock = result.GetDouble(4),
                            Description = result.IsDBNull(5) ? null : result.GetString(5),
                            ImageUrl = result.GetString(6)                          
                        };
                        Products.Add(product);
                    }
                }
                _context.Database.CloseConnection();
            }
            return Products;
        }
        public async Task<Product> GetProductAsJsonAsync(string id)
        {
            var commandText = $"SELECT * FROM get_product_as_json(@p_id);";

            try
            {
                // Parse the string to a Guid
                var productId = Guid.Parse(id);
                 
                using (var command = _context.Database.GetDbConnection().CreateCommand())
                {
                    command.CommandText = commandText;
                    command.CommandType = CommandType.Text;

                    var parameter = command.CreateParameter();
                    parameter.ParameterName = "@p_id";
                    parameter.Value = productId;  // Pass the parsed GUID
                    command.Parameters.Add(parameter);

                    _context.Database.OpenConnection();

                    using (var result = await command.ExecuteReaderAsync())
                    {
                        if (await result.ReadAsync())
                        {
                            var jsonResult = result.GetString(0);

                            var product = JsonConvert.DeserializeObject<Product>(jsonResult);

                            return product;
                        }
                    }
                    _context.Database.CloseConnection();
                }
            }
            catch (FormatException ex)
            {
                // Handle invalid UUID format here
                Console.WriteLine($"Invalid UUID format: {ex.Message}");
                return null;
            }
            catch (Exception ex)
            {
                // Handle any other errors
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }

            return null;
        }
    }
}

