 using System;
using Domain.Entities.BaseEntity;

namespace Application.Repositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity 
    {
        // Insert - Update - Delete Operations
        Task<bool> AddAsync(T model);
        Task<bool> AddRangeAsync(List<T> model);

        bool Remove(T model);
        bool Remove(string id);

        Task<bool> UpdateAsync(T model);

        Task<int> SaveAsync();

    }
}

