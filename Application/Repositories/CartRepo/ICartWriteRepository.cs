using System;
using Domain;

namespace Application.Repositories
{
    public interface ICartWriteRepository : IWriteRepository<Cart>
    {
        Task<List<Cart>> CreateCartsForUsers(string? userId);
    }
}

