using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Driver;
using Play.catalog.Service.Entities;

namespace Play.catalog.Service.Repositories
{
    public class MongoRepository<T> : IRepository<T> where T : IEntity
    {
        private readonly IMongoCollection<T> dbCollection;

        private readonly FilterDefinitionBuilder<T> filterBuilder = Builders<T>.Filter;

        public MongoRepository(IMongoDatabase database, string collectionName)
        {
            this.dbCollection = database.GetCollection<T>(collectionName);
        }

        // public ItemsRepository()
        // {
        //     var mongoClient = new MongoClient("mongodb://localhost:27017");
        //     var database = mongoClient.GetDatabase("Catalog");
        //     dbCollection = database.GetCollection<Item>(collectionName);
        // }

        public async Task<IReadOnlyCollection<T>> GetAllAsync()
        {
            return await dbCollection.Find(filterBuilder.Empty).ToListAsync();
        }

        public async Task<T> GetAsync(Guid id)
        {
            FilterDefinition<T> filter = filterBuilder.Eq(x => x.Id, id);

            return await dbCollection.Find(filter).FirstOrDefaultAsync();
        }

        public async Task CreateAsync(T entity)
        {
            if (entity is null)
            {
                throw new ArgumentException(nameof(entity));
            }

            await dbCollection.InsertOneAsync(entity);
        }

        public async Task UpdateAsync(T entity)
        {
            if (entity is null)
            {
                throw new ArgumentException(nameof(entity));
            }

            FilterDefinition<T> filter = filterBuilder.Eq(x => x.Id, entity.Id);

            await dbCollection.ReplaceOneAsync(filter, entity);
        }

        public async Task RemoveAsync(Guid id)
        {
            FilterDefinition<T> filter = filterBuilder.Eq(x => x.Id, id);

            await dbCollection.DeleteOneAsync(filter);
        }
    }
}