using System;
using Application.DTOs;

namespace Application.Features.Queries.Users.GetUsersWhere
{
    public class GetUsersWhereQueryResponse 
    {
        public string Name { get; set; }
        public string? Surname { get; set; }
        public string Id { get; set; }
        public string Email { get; set; }
        public bool Role { get; set; }
    }
}

