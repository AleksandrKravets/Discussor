using Discussor.Core.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Discussor.Core.Application.Common.Contracts.Services
{
    public interface IPostService
    {
        Task<int> CreateAsync(Post post);
        Task<Post> GetPostByIdAsync(int postId);
        Task<IEnumerable<Post>> GetAllPostsAsync();
        Task<bool> UpdateAsync(Post post);
        Task<bool> DeleteAsync(int postId);
        Task<IEnumerable<Post>> GetPostsByThemeIdAsync(int themeId);
    }
}
