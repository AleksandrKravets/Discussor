using Discussor.Core.Application.Common.Contracts.Repositories;
using Discussor.Core.Domain.Entities;
using Discussor.Infrastructure.Contracts;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<string> Create(User user)
        {
            var newUser = new Identity.User
            {
                UserName = user.UserName
            };

            await _context.Users.AddAsync(newUser);
            await _context.SaveChangesAsync();

            return newUser.Id;
        }

        public async Task<bool> Delete(string userId)
        {
            var user = await _context.Users.FindAsync(userId);

            if (user == null)
                return false;

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return true;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _context.Users
                .Select(user => new Core.Domain.Entities.User
                {
                    Id = user.Id,
                    UserName = user.UserName
                });
        }

        public async Task<User> GetUserById(string userId)
        {
            var user = await _context.Users.FindAsync(userId);

            return new Core.Domain.Entities.User
            {
                Id = user.Id,
                UserName = user.UserName
            };
        }

        public async Task<bool> Update(User user)
        {
            var userToUpdate = await _context.Users.FindAsync(user.Id);

            if (userToUpdate == null)
                return false;

            userToUpdate.UserName = user.UserName;

            await _context.SaveChangesAsync();

            return true;
        }
    }
}
