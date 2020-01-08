using Discussor.Core.Application.Common.Contracts.Services;
using Discussor.Core.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Discussor.Core.Application.Common.Services
{
    public class UserService : IUserService
    {
        public Task<string> CreateAsync(User user)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> DeleteAsync(int userId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<User> GetAllUsers()
        {
            throw new System.NotImplementedException();
        }

        public Task<User> GetUserByIdAsync(string userId)
        {
            throw new System.NotImplementedException();
        }
    }
}
