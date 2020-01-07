using Discussor.Core.Application.Common.Contracts.Repositories;
using Discussor.Core.Application.Common.Contracts.Services;
using Discussor.Core.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Discussor.Core.Application.Common.Services
{
    public class ReplyService : IReplyService
    {
        private readonly IReplyRepository _replyRepository;

        public ReplyService(IReplyRepository replyRepository)
        {
            _replyRepository = replyRepository;
        }

        public async Task<int> CreateAsync(Reply reply)
        {
            return await _replyRepository.Create(reply);
        }

        public async Task<bool> DeleteAsync(int replyId)
        {
            return await _replyRepository.Delete(replyId);
        }

        public IEnumerable<Reply> GetAllReplies()
        {
            return _replyRepository.GetAllReplies().ToList();
        }

        public IEnumerable<Reply> GetRepliesByPostId(int postId)
        {
            return _replyRepository.GetAllReplies()
                .Where(reply => reply.PostId == postId)
                .ToList();
        }

        public async Task<Reply> GetReplyByIdAsync(int replyId)
        {
            return await _replyRepository.GetReplyById(replyId);
        }

        public async Task<bool> UpdateAsync(Reply reply)
        {
            return await _replyRepository.Update(reply);
        }
    }
}
