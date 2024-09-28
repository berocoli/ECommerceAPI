using System;
using Application.DTOs;
using MediatR;

namespace Application.Features.Commands.Orders.CreateOrder
{
    public class CreateOrderCommandRequest : IRequest<CreateOrderCommandResponse>
    {
        public string Status { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
    }
}

