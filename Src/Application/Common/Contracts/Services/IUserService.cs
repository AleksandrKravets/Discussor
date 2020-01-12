using Discussor.Core.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Discussor.Core.Application.Common.Contracts.Services
{
    public interface IUserService
    {
        Task<string> CreateAsync(ApplicationUser user);
        Task<ApplicationUser> GetUserByIdAsync(string userId);
        IEnumerable<ApplicationUser> GetAllUsers();
        Task<bool> DeleteAsync(string userId);
    }
}
