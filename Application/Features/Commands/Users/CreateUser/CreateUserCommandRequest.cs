using System;
using Application.DTOs;
using MediatR;

namespace Application.Features.Commands.Users.CreateUser
{
    public class CreateUserCommandRequest : IRequest<CreateUserCommandResponse>
    {
        public CreateUserDto CreateUser { get; set; }
    }
}

