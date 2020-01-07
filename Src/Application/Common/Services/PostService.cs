using Discussor.Core.Application.Common.Contracts.Repositories;
using Discussor.Core.Application.Common.Contracts.Services;
using Discussor.Core.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Discussor.Core.Application.Common.Services
{
    public class PostService : IPostService
    {
        private readonly IPostRepository _postRepository;

        public PostService(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public async Task<int> CreateAsync(Post post)
        {
            return await _postRepository.Create(post);
        }

        public async Task<bool> DeleteAsync(int postId)
        {
            return await _postRepository.Delete(postId);
        }

        public IEnumerable<Post> GetAllPosts()
        {
            return _postRepository.GetAllPosts().ToList();
        }

        public async Task<Post> GetPostByIdAsync(int postId)
        {
            return await _postRepository.GetPostById(postId);
        }

        public IEnumerable<Post> GetPostsByThemeId(int themeId)
        {
            return _postRepository.GetAllPosts()
                            .Where(post => post.ThemeId == themeId)
                            .ToList();
        }

        public async Task<bool> UpdateAsync(Post post)
        {
            return await _postRepository.Update(post);
        }
    }
}
