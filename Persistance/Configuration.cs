using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace Persistance
{
    static class Configuration
    {
        static public string ConnectionString
        {
            get
            {
                var basePath = AppContext.BaseDirectory;
                var configurationManager = new ConfigurationBuilder()
                    .SetBasePath(basePath)
                    .AddJsonFile(Path.Combine(basePath, "appsettings.json"))
                    .Build();

                return configurationManager.GetConnectionString("PostgreSQL");
            }
        }
    }
}
