using System.Threading.Tasks;
using Application.Use_Cases.Create;
using Domain.Contracts;
using Domain.Entities;

namespace Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly CreateUserUseCase _createUserUseCase;

        public UserService(CreateUserUseCase createUserUseCase)
        {
            _createUserUseCase = createUserUseCase;
        }

        public async Task<User> CreateUser(User user)
        {
            return await _createUserUseCase.Execute(user);
        }
    }
}
