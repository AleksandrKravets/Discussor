using Discussor.Core.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Discussor.Core.Application.Common.Contracts.Services
{
    public interface IUserService
    {
        Task<int> CreateAsync(ApplicationUser user);
        Task<ApplicationUser> GetUserByIdAsync(int userId);
        IEnumerable<ApplicationUser> GetAllUsers();
        Task<bool> DeleteAsync(int userId);
    }
}
