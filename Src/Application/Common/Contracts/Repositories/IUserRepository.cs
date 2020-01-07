using Discussor.Core.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Discussor.Core.Application.Common.Contracts.Repositories
{
    public interface IUserRepository
    {
        Task<int> Create(User user);
        Task<User> GetUserById(string userId);
        Task<IEnumerable<User>> GetAllUsers();
        Task Update(User user);
        Task Delete(string userId);
    }
}
