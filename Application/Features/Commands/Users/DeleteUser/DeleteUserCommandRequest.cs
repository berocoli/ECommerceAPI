using System;
using MediatR;

namespace Application.Features.Commands.Users.DeleteUser
{
    public class DeleteUserCommandRequest : IRequest<DeleteUserCommandResponse>
    {
        public string Id { get; set; }
    }
}

