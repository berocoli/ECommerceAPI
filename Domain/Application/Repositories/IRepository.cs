using System;
using Microsoft.EntityFrameworkCore;
using Domain.Entities.BaseEntity;

namespace Application.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        DbSet<T> Table { get; }
    }
}

