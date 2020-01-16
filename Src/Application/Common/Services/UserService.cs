using Discussor.Core.Application.Common.Contracts.Repositories;
using Discussor.Core.Application.Common.Contracts.Services;
using Discussor.Core.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Discussor.Core.Application.Common.Services
{
    //public class UserService : IUserService
    //{
    //    private readonly IUserRepository _userRepository;

    //    public UserService(IUserRepository userRepository)
    //    {
    //        _userRepository = userRepository;
    //    }

    //    public async Task<string> CreateAsync(ApplicationUser user)
    //    {
    //        return await _userRepository.Create(user);
    //    }

    //    public async Task<bool> DeleteAsync(string userId)
    //    {
    //        return await _userRepository.Delete(userId);
    //    }

    //    public IEnumerable<ApplicationUser> GetAllUsers()
    //    {
    //        return _userRepository.GetAllUsers().ToList();
    //    }

    //    public async Task<ApplicationUser> GetUserByIdAsync(string userId)
    //    {
    //        return await _userRepository.GetUserById(userId);
    //    }
    //}
}
