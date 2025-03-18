using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Contracts
{
    public interface IUserService
    {
        Task<User> CreateUser(User user);
    }
}
