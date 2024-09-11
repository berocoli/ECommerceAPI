using System;
using MediatR;

namespace Application.Features.Commands.Orders.DeleteOrder
{
    public class DeleteOrderCommandRequest : IRequest<DeleteOrderCommandResponse>
    {
        public string Id { get; set; }
    }
}