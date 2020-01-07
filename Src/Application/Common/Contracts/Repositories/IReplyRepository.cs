using Discussor.Core.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Discussor.Core.Application.Common.Contracts.Repositories
{
    public interface IReplyRepository
    {
        Task<int> Create(Reply reply);
        Task<Reply> GetReplyById(int replyId);
        Task<IEnumerable<Reply>> GetAllReplies();
        Task Update(Reply reply);
        Task Delete(int replyId);
    }
}
