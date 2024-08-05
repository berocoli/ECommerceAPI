using System.Threading.Tasks;
using System.Xml.Linq;

namespace Application.Services.CurrencyServices
{
    public interface ICurrencyConverterServices
    {
        Task<string> ConvertXmlToJson(XDocument xmlDocument);
    }
}
