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
            return await _postRepository.CreateAsync(post);
        }

        public async Task<bool> DeleteAsync(int postId)
        {
            return await _postRepository.DeleteAsync(postId);
        }

        public async Task<IEnumerable<Post>> GetAllPostsAsync()
        {
            return await _postRepository.GetAllPostsAsync();
        }

        public async Task<Post> GetPostByIdAsync(int postId)
        {
            return await _postRepository.GetPostByIdAsync(postId);
        }

        public async Task<IEnumerable<Post>> GetPostsByThemeIdAsync(int themeId)
        {
            var posts = await _postRepository.GetAllPostsAsync();
            return posts.Where(post => post.ThemeId == themeId).ToList();
        }

        public async Task<bool> UpdateAsync(Post post)
        {
            return await _postRepository.UpdateAsync(post);
        }
    }
}
