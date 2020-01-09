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

        public async Task<int> Create(ApplicationUser user)
        {
            await _context.ApplicationUsers.AddAsync(user);
            await _context.SaveChangesAsync();
            return user.Id;
        }

        public async Task<bool> Delete(int userId)
        {
            var user = await _context.ApplicationUsers.FindAsync(userId);

            if (user == null)
                return false;

            _context.ApplicationUsers.Remove(user);
            await _context.SaveChangesAsync();

            return true;
        }

        public IEnumerable<ApplicationUser> GetAllUsers()
        {
            return _context.ApplicationUsers;
        }

        public async Task<ApplicationUser> GetUserById(int userId)
        {
            return await _context.ApplicationUsers.FindAsync(userId);
        }

        public async Task<bool> Update(ApplicationUser user)
        {
            var userToUpdate = await _context.ApplicationUsers.FindAsync(user.Id);

            if (userToUpdate == null)
                return false;

            userToUpdate.NickName = user.NickName;

            await _context.SaveChangesAsync();

            return true;
        }
    }
}
