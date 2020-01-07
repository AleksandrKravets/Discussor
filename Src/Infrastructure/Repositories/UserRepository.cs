using Discussor.Core.Application.Common.Contracts.Repositories;
using Discussor.Core.Domain.Entities;
using Discussor.Infrastructure.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Discussor.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IApplicationDbContext _context;

        public UserRepository(IApplicationDbContext context)
        {
            _context = context;
        }

        public Task<int> Create(User user)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Delete(string userId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<User> GetAllUsers()
        {
            throw new System.NotImplementedException();
        }

        public Task<User> GetUserById(string userId)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Update(User user)
        {
            throw new System.NotImplementedException();
        }
    }
}
