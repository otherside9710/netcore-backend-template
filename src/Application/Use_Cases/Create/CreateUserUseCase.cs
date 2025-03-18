using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Contracts;

namespace Application.Use_Cases.Create
{
    public class CreateUserUseCase
    {
        private readonly IUserRepository _userRepository;
        public CreateUserUseCase(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<User> Execute(User user)
        {
            return await _userRepository.CreateUser(user);
        }
    }
}