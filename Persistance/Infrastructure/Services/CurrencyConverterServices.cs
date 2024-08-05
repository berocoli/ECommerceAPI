using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json;
using Application.Services.CurrencyServices;

public class CurrencyConverterServices : ICurrencyConverterServices
{
    public Task<string> ConvertXmlToJson(XDocument xmlDocument)
    {
        var currencies = xmlDocument.Descendants("Currency")
            .Where(currency =>
                currency.Attribute("Kod") != null &&
                (currency.Attribute("Kod").Value == "USD" ||
                 currency.Attribute("Kod").Value == "EUR" ||
                 currency.Attribute("Kod").Value == "JPY" ||
                 currency.Attribute("Kod").Value == "CHF" ||
                 currency.Attribute("Kod").Value == "QAR"))
            .Select(currency => new
            {
                CurrencyCode = currency.Attribute("Kod").Value,
                ForexBuying = currency.Element("ForexBuying")?.Value ?? "N/A",
                ForexSelling = currency.Element("ForexSelling")?.Value ?? "N/A"
            })
            .ToList();

        var jsonResult = JsonConvert.SerializeObject(currencies, Formatting.Indented);
        return Task.FromResult(jsonResult);
    }
}
