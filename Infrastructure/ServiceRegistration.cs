using Application.Services.CurrencyServices;
using Application.Services.TokenServices;
using Application.Settings;
using Infrastructure.Services;
using Infrastructure.Services.Token;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

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

            services.AddScoped<ITokenService, TokenService>(provider =>
            {
                var jwtSettings = provider.GetRequiredService<IOptions<JwtSettings>>().Value;
                return new TokenService(jwtSettings.Secret);
            });
        }
    }
}
