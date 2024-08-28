using System;
using Application.DTOs;
using MediatR;
namespace Application.Features.Queries.Orders.GetAllOrders
{
    public class GetAllUsersQueryRequest : IRequest<List<UserDto>>
    {
        public GetAllUsersQueryRequest()
        {
        }
    }
}

