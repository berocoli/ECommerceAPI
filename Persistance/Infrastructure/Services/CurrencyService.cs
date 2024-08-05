using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Linq;
using Application.Services.CurrencyServices;

namespace Infrastructure.Services
{
    public class CurrencyService : ICurrencyService
    {
        private readonly HttpClient _httpClient;

        public CurrencyService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<XDocument> GetExchangeRatesAsync()
        {
            var response = await _httpClient.GetStringAsync("https://www.tcmb.gov.tr/kurlar/today.xml");
            return XDocument.Parse(response);
        }
    }
}
