using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace Persistance
{
    static public class Configuration
    {
        static public string ConnectionString
        {
            get
            {
                var basePath = AppContext.BaseDirectory;
                var configurationManager = new ConfigurationBuilder()
                    .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../ECommerceAPI.API"))
                    .AddJsonFile("appsettings.json")
                    .Build();

                return configurationManager.GetConnectionString("PostgreSQL");
            }
        }
    }
}
