using Discussor.Core.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Discussor.Core.Application.Common.Contracts.Services
{
    public interface IReplyService
    {
        Task<int> CreateAsync(Reply reply);
        Task<Reply> GetReplyByIdAsync(int replyId);
        IEnumerable<Reply> GetAllReplies();
        Task<bool> UpdateAsync(Reply reply);
        Task<bool> DeleteAsync(int replyId);
        IEnumerable<Reply> GetRepliesByPostId(int postId);
        IEnumerable<Reply> GetRepliesByPostId(int postId, int pageNumber, int pageSize = 7);
        int GetRepliesNumberByPostId(int postId);

    }
}
