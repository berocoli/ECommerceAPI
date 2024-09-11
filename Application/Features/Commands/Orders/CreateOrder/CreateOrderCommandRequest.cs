using System;
using Application.DTOs;
using MediatR;

namespace Application.Features.Commands.Orders.CreateOrder
{
    public class CreateOrderCommandRequest : IRequest<CreateOrderCommandResponse>
    {
        public CreateOrderDto CreateOrder { get; set; }
    }
}

