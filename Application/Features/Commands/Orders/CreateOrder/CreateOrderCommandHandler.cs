using Application.Services;
using MediatR;

namespace Application.Features.Commands.Orders.CreateOrder
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommandRequest, CreateOrderCommandResponse>
    {
        private readonly IOrderService _orderService;
        public CreateOrderCommandHandler(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public async Task<CreateOrderCommandResponse> Handle(CreateOrderCommandRequest request, CancellationToken cancellationToken)
        {
            var result = await _orderService
                .CreateOrderAsync(request.UserId, request.CartId,
                request.Status, request.Address, request.Description);
            if(result == false)
            {
                return new CreateOrderCommandFailResponse
                {
                    ErrorMessage = "Order creation unsuccessful."
                };
            }

            return new CreateOrderCommandResponse
            {
                Message = "Order created successfully!"
            };
        }
    }
}
