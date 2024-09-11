using System;
using Application.Services;
using MediatR;

namespace Application.Features.Commands.Orders.DeleteOrder
{
    public class DeleteOrderCommandHandler : IRequestHandler<DeleteOrderCommandRequest, DeleteOrderCommandResponse>
    {
        private readonly IOrderService _orderService;
        public DeleteOrderCommandHandler(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public async Task<DeleteOrderCommandResponse> Handle(DeleteOrderCommandRequest request, CancellationToken cancellationToken)
        {
            var result = await _orderService.DeleteOrderAsync(request.Id);
            if(result == false)
            {
                return new DeleteOrderCommandResponse
                {
                    Message = "Deletion failed."
                };
            }

            return new DeleteOrderCommandResponse
            {
                Message = "Deletion successfully executed!"
            };
        }
    }
}

