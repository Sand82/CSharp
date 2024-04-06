using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Play.Common
{
    public interface IRepository<T> where T : IEntity
    {
        Task<IReadOnlyCollection<T>> GetAllAsync();

        Task<T> GetAsync(Guid id);

        Task CreateAsync(T entity);

        Task UpdateAsync(T entity);

        Task RemoveAsync(Guid id);
    }
}