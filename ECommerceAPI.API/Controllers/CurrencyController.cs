using Application.Features.Commands.Currency;
using Application.Services.CurrencyServices;
using MediatR;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class CurrencyController : ControllerBase
{
    private readonly IMediator _mediator;
    //private readonly ICurrencyService _currencyService;
    //private readonly ICurrencyConverterServices _currencyConverter;

    public CurrencyController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("rates")]
    public async Task<IActionResult> GetRates()
    {
        var currencies = await _mediator.Send(new CurrencyCommandRequest());  // Use await to get the result
        return Ok(currencies);  // Return the list directly
    }

    //[HttpGet("rates/service")]
    //public async Task<IActionResult> GetRatesService()
    //{
    //    var xmlCurrency = await _currencyService.GetExchangeRatesAsync();
    //    var jsonFormat = await _currencyConverter.ConvertXmlToJson(xmlCurrency);
    //    return Ok(jsonFormat);
    //}
}