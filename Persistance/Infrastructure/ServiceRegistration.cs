using Application.Services.CurrencyServices;
using Application.Services.TokenServices;
using Infrastructure.Services;
using Infrastructure.Services.Token;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.ServiceRegistration
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection services)
        {
            // Register HttpClient for CurrencyService
            services.AddHttpClient<ICurrencyService, CurrencyService>();

            // Register other services
            services.AddScoped<ICurrencyConverterServices, CurrencyConverterServices>();
            services.AddScoped<ITokenService, TokenService>();
        }
    }
}
