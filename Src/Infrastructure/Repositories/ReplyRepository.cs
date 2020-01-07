using Discussor.Core.Application.Common.Interfaces;
using Discussor.Core.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Discussor.Infrastructure.Repositories
{
    public class ReplyRepository : IReplyRepository
    {
        public Task<int> Create(Reply reply)
        {
            throw new System.NotImplementedException();
        }

        public Task Delete(int replyId)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Reply>> GetAllReplies()
        {
            throw new System.NotImplementedException();
        }

        public Task<Reply> GetReplyById(int replyId)
        {
            throw new System.NotImplementedException();
        }

        public Task Update(Reply reply)
        {
            throw new System.NotImplementedException();
        }
    }
}
