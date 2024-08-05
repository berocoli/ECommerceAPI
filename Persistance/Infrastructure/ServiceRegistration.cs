using Application.Services.CurrencyServices;
using Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection services)
        {
            // Register HttpClient for CurrencyService
            services.AddHttpClient<ICurrencyService, CurrencyService>();

            // Register other services
            services.AddScoped<ICurrencyConverterServices, CurrencyConverterServices>();
        }
    }
}
