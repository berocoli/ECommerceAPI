using System;
using Application.Services;
using MediatR;

namespace Application.Features.Commands.Orders.UpdateOrder
{
    public class UpdateOrderCommandHandler : IRequestHandler<UpdateOrderCommandRequest, UpdateOrderCommandResponse>
    {
        private readonly IOrderService _orderService;
        public UpdateOrderCommandHandler(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public async Task<UpdateOrderCommandResponse> Handle(UpdateOrderCommandRequest request, CancellationToken cancellationToken)
        {
            var result = await _orderService.UpdateOrderAsync(request.UpdateOrder);
            if(result == false)
            {
                return new UpdateOrderCommandResponse
                {
                    Message = "Order update execution failed."
                };
            }

            return new UpdateOrderCommandResponse
            {
                Message = "Order update executed successfully!"
            };
        }
    }
}

