using System;
using MediatR;

namespace Application.Features.Queries.Users.GetUsersWhere
{ 
    public class GetUsersWhereQueryRequest : IRequest<List<GetUsersWhereQueryResponse>>
    {
        public string Name { get; set; }
        public string? Surname { get; set; }
    }
}

