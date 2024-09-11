using System;
using Application.DTOs;
using MediatR;

namespace Application.Features.Commands.Orders.UpdateOrder
{
    public class UpdateOrderCommandRequest : IRequest<UpdateOrderCommandResponse>
    {
        public UpdateOrderDto UpdateOrder { get; set; }
    }
}

