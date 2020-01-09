using Discussor.Core.Application.Common.Contracts.Repositories;
using Discussor.Core.Domain.Entities;
using Discussor.Infrastructure.Contracts;
using Microsoft.EntityFrameworkCore;
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

        public async Task<int> Create(Post post)
        {
            await _context.Posts.AddAsync(post);
            await _context.SaveChangesAsync();
            return post.Id;
        }

        public async Task<bool> Delete(int postId)
        {
            var post = await _context.Posts.FindAsync(postId);

            if (post == null)
                return false;

            _context.Posts.Remove(post);
            await _context.SaveChangesAsync();

            return true;
        }

        public IEnumerable<Post> GetAllPosts()
        {
            return _context.Posts;
        }

        public async Task<Post> GetPostById(int postId)
        {
            return await _context.Posts.FindAsync(postId);
        }

        public async Task<bool> Update(Post post)
        {
            var postToUpdate = await _context.Posts.FindAsync(post.Id);

            if (postToUpdate == null)
                return false;

            postToUpdate.Title = post.Title;
            postToUpdate.Content = post.Content;
            postToUpdate.DateOfCreation = DateTime.Now;

            await _context.SaveChangesAsync();

            return true;
        }
    }
}
