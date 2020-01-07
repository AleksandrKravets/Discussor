using Discussor.Core.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Discussor.Core.Application.Common.Contracts.Repositories
{
    public interface IPostRepository
    {
        Task<int> Create(Post post);
        Task<Post> GetPostById(int postId);
        IEnumerable<Post> GetAllPosts();
        Task<bool> Update(Post post);
        Task<bool> Delete(int postId);
    }
}
