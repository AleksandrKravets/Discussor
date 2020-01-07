using Discussor.Core.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Discussor.Core.Application.Common.Contracts.Repositories
{
    public interface IUserRepository
    {
        Task<int> Create(User user);
        Task<User> GetUserById(string userId);
        IEnumerable<User> GetAllUsers();
        Task<bool> Update(User user);
        Task<bool> Delete(string userId);
    }
}
