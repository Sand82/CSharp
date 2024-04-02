using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Play.catalog.Service.Entities;

namespace Play.catalog.Service.Repositories
{
    public interface IItemsRepository
    {
        Task<IReadOnlyCollection<Item>> GetAllAsync();

        Task<Item> GetAsync(Guid id);

        Task CreateAsync(Item entity);

        Task UpdateAsync(Item entity);

        Task RemoveAsync(Guid id);
    }
}