using Discussor.Core.Application.Common.Contracts.Repositories;
using Discussor.Core.Domain.Entities;
using Discussor.Infrastructure.Contracts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Discussor.Infrastructure.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly IApplicationDbContext _context;

        public PostRepository(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> CreateAsync(Post post)
        {
            await _context.Posts.AddAsync(post);
            await _context.SaveChangesAsync();
            return post.Id;
        }

        public async Task<bool> DeleteAsync(int postId)
        {
            var post = await _context.Posts.FindAsync(postId);

            if (post == null)
                return false;

            _context.Posts.Remove(post);
            await _context.SaveChangesAsync();

            return true;
        }

        public Task<IEnumerable<Post>> GetAllPostsAsync()
        {
            return new Task<IEnumerable<Post>>(() => _context.Posts);
        }

        public async Task<Post> GetPostByIdAsync(int postId)
        {
            return await _context.Posts.FindAsync(postId);
        }

        public async Task<bool> UpdateAsync(Post post)
        {
            var postToUpdate = await _context.Posts.FindAsync(post.Id);

            if (postToUpdate == null)
                return false;

            postToUpdate.Content = post.Content;
            postToUpdate.DateOfCreation = DateTime.Now;
            postToUpdate.Title = post.Title;
            postToUpdate.ThemeId = post.ThemeId;

            return true;
        }
    }
}
