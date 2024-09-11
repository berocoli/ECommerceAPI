using System;
using Application.DTOs;
using MediatR;

namespace Application.Features.Commands.Users.UpdateUser
{
    public class UpdateUserCommandRequest : IRequest<UpdateUserCommandResponse>
    {
        public UpdateUserDto UpdateUser { get; set; }
    }
}

