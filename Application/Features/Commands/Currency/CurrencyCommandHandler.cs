using System.Xml.Linq;
using MediatR;

namespace Application.Features.Commands.Currency
{
    public class CurrencyCommandHandler : IRequestHandler<CurrencyCommandRequest, List<CurrencyCommandResponse>>
    {
        private readonly HttpClient _httpClient;
        public CurrencyCommandHandler(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<CurrencyCommandResponse>> Handle(CurrencyCommandRequest request, CancellationToken cancellationToken)
        {
            var response = await _httpClient.GetStringAsync("https://www.tcmb.gov.tr/kurlar/today.xml");
            var xml = XDocument.Parse(response);
            return ConvertXmlToJson(xml);
        }

        private List<CurrencyCommandResponse> ConvertXmlToJson(XDocument xmlDocument) //Will return a List of CurrencyCommandResponse
        {
            var currencies = xmlDocument.Descendants("Currency")
                .Where(currency =>
                    currency.Attribute("Kod") != null &&
                    (currency.Attribute("Kod").Value == "USD" ||
                     currency.Attribute("Kod").Value == "EUR" ||
                     currency.Attribute("Kod").Value == "JPY" ||
                     currency.Attribute("Kod").Value == "CHF" ||
                     currency.Attribute("Kod").Value == "QAR"))
                .Select(currency => new CurrencyCommandResponse // var currencies is type of response.
                {
                    CurrencyCode = currency.Attribute("Kod").Value,
                    ForexBuying = currency.Element("ForexBuying")?.Value ?? "N/A",
                    ForexSelling = currency.Element("ForexSelling")?.Value ?? "N/A"
                })
                .ToList();

            return currencies; // Returns currencies directly since it's already a type of response.
        }
    }
}
