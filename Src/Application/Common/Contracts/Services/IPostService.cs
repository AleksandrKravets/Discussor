using Discussor.Core.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Discussor.Core.Application.Common.Contracts.Services
{
    public interface IPostService
    {
        Task<int> CreateAsync(Post post);
        Task<Post> GetPostByIdAsync(int postId);
        IEnumerable<Post> GetAllPosts();
        Task<bool> UpdateAsync(Post post);
        Task<bool> DeleteAsync(int postId);
        IEnumerable<Post> GetPostsByThemeId(int themeId);
        IEnumerable<Post> GetPostsByThemeId(int themeId, int pageNumber, int pageSize = 7);
        int GetPostsNumberByThemeId(int themeId);
    }
}
