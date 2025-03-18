using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Infrastructure.Persistence.Mongo.Entities
{
    public class UserEntity
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public UserEntity(User user)
        {
            Id = user.Id;
            Name = user.Name;
            LastName = user.LastName;
            Email = user.Email;
            Phone = user.Phone;
        }

        public User ToDomain()
        {
            return new User
            {
                Name = Name,
                LastName = LastName,
                Email = Email,
                Phone = Phone
            };
        }
    }
}