using Discussor.Core.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Discussor.Core.Application.Common.Contracts.Services
{
    public interface IUserService
    {
        Task<string> CreateAsync(User user);
        Task<User> GetUserByIdAsync(string userId);
        IEnumerable<User> GetAllUsers();
        Task<bool> DeleteAsync(int userId);
    }
}
