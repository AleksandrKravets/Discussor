using Discussor.Core.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Discussor.Core.Application.Common.Contracts.Repositories
{
    public interface IUserRepository
    {
        Task<string> Create(ApplicationUser user);
        Task<ApplicationUser> GetUserById(string userId);
        IEnumerable<ApplicationUser> GetAllUsers();
        Task<bool> Update(ApplicationUser user);
        Task<bool> Delete(string userId);
    }
}
