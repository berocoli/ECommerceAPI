using System;

namespace Application.Features.Commands.Currency
{
    public class CurrencyCommandResponse
    {
        public string CurrencyCode { get; set; }
        public string ForexBuying { get; set; }
        public string ForexSelling { get; set; }
        public string Unit { get; set; }
    }
}
