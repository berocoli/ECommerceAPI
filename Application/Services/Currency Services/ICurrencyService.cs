using System.Threading.Tasks;
using System.Xml.Linq;

namespace Application.Services.CurrencyServices
{
    public interface ICurrencyService
    {
        Task<XDocument> GetExchangeRatesAsync();
    }
}
