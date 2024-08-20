using Application.Services.CurrencyServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class CurrencyController : ControllerBase
{
    private readonly ICurrencyService _currencyService;
    private readonly ICurrencyConverterServices _currencyConverter;

    public CurrencyController(ICurrencyService currencyService, ICurrencyConverterServices currencyConverter)
    {
        _currencyService = currencyService;
        _currencyConverter = currencyConverter;
    }

    [HttpGet("rates")]
    [Authorize]
    public async Task<IActionResult> GetRates()
    {
        var xmlData = await _currencyService.GetExchangeRatesAsync();
        var jsonData = await _currencyConverter.ConvertXmlToJson(xmlData);
        return Ok(jsonData);
    }
}
