using Application.Services.CurrencyServices;
using Application.Services.PdfServices;
using Application.Services.TokenServices;
using Application.Settings;
using Infrastructure.Services;
using Infrastructure.Services.TokenServices;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Persistence.Services.Pdf_Services;

namespace Infrastructure.ServiceRegistration
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection services)
        {
            // Register HttpClient for CurrencyService
            services.AddHttpClient<ICurrencyService, CurrencyService>();

            services.AddScoped<ICurrencyConverterServices, CurrencyConverterServices>();

            services.AddScoped<ITokenHandler, TokenHandler>();
            services.AddSingleton<IPdfServices, PdfSharpService>();
        }
    }
}
