using System;
namespace Application.Features.Queries.Users.GetUsersById
{
    public class GetUsersByIdQueryResponse
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public bool Role { get; set; }
    }
}

