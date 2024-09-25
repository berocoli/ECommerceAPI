using System;
using Application.DTOs;
using MediatR;

namespace Application.Features.Commands.Users.CreateUser
{
    public class CreateUserCommandRequest : IRequest<CreateUserCommandResponse>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }

        //public CreateUserDto CreateUser { get; set; }
    }
}

