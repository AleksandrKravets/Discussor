using Discussor.Core.Application.Common.Interfaces;
using Discussor.Core.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Discussor.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        public Task<int> Create(User user)
        {
            throw new System.NotImplementedException();
        }

        public Task Delete(string userId)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAllUsers()
        {
            throw new System.NotImplementedException();
        }

        public Task<User> GetUserById(string userId)
        {
            throw new System.NotImplementedException();
        }

        public Task Update(User user)
        {
            throw new System.NotImplementedException();
        }
    }
}
