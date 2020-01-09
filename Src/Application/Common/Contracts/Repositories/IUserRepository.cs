using Discussor.Core.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Discussor.Core.Application.Common.Contracts.Repositories
{
    public interface IUserRepository
    {
        Task<int> Create(ApplicationUser user);
        Task<ApplicationUser> GetUserById(int userId);
        IEnumerable<ApplicationUser> GetAllUsers();
        Task<bool> Update(ApplicationUser user);
        Task<bool> Delete(int userId);
    }
}
