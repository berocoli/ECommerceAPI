using System;
using Application.DTOs;
using MediatR;

namespace Application.Features.Commands.Users.UpdateUser
{
    public class UpdateUserCommandRequest : IRequest<UpdateUserCommandResponse>
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
        public bool Role { get; set; }
    }
}

