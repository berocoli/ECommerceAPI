using System;
namespace Application.Features.Commands.Orders.CreateOrder
{
    public class CreateOrderCommandResponse
    {
        public string Message { get; set; }
    }

    public class CreateOrderCommandFailResponse : CreateOrderCommandResponse
    {
        public string ErrorMessage { get; set; }
    }
}
