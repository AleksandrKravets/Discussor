using Discussor.Core.Application.Common.Contracts.Repositories;
using Discussor.Core.Domain.Entities;
using Discussor.Infrastructure.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Discussor.Infrastructure.Repositories
{
    public class ReplyRepository : IReplyRepository
    {
        private readonly IApplicationDbContext _context;

        public ReplyRepository(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Create(Reply reply)
        {
            await _context.PostReplies.AddAsync(reply);
            await _context.SaveChangesAsync();
            return reply.Id;
        }

        public async Task<bool> Delete(int replyId)
        {
            var reply = await _context.PostReplies.FindAsync(replyId);

            if (reply == null)
                return false;

            _context.PostReplies.Remove(reply);
            await _context.SaveChangesAsync();

            return true;
        }

        public IEnumerable<Reply> GetAllReplies()
        {
            return _context.PostReplies;
        }

        public async Task<Reply> GetReplyById(int replyId)
        {
            return await _context.PostReplies.FindAsync(replyId);
        }

        public async Task<bool> Update(Reply reply)
        {
            var replyToUpdate = await _context.PostReplies.FindAsync(reply.Id);

            if (replyToUpdate == null)
                return false;

            replyToUpdate.Content = reply.Content;
            replyToUpdate.DateOfCreation = DateTime.Now;
            replyToUpdate.PostId = reply.PostId;

            await _context.SaveChangesAsync();

            return true;
        }
    }
}
