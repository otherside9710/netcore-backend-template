using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using Domain.Contracts;
using Domain.Entities;
using Infrastructure.Persistence.Mongo.Entities;

namespace Infrastructure.Persistence.Mongo.Repositories
{
    public class MongoUserRepository : IUserRepository
    {
        private readonly IMongoCollection<UserEntity> _users;

        public MongoUserRepository(IMongoDatabase database)
        {
            _users = database.GetCollection<UserEntity>("users");
        }

        public async Task<User> CreateUser(User user)
        {
            var userDocument = new UserEntity(user);
            await _users.InsertOneAsync(userDocument);
            return userDocument.ToDomain();
        }
    }
}