using System;
using Domain;

namespace Application.Repositories
{
    public interface ICartReadRepository : IReadRepository<Cart>
    {
        Task<List<Cart>> GetCartsByIdAsyncSP(string userId);
    }
}

