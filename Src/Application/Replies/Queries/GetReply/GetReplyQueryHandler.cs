using Discussor.Core.Application.Common.Contracts.Services;
using Discussor.Core.Application.Common.Exceptions;
using Discussor.Core.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Discussor.Core.Application.Replies.Queries.GetReply
{
    public class GetReplyQueryHandler : IRequestHandler<GetReplyQuery, ReplyViewModel>
    {
        private readonly IReplyService _replyService;

        public GetReplyQueryHandler(IReplyService replyService)
        {
            _replyService = replyService;
        }

        public async Task<ReplyViewModel> Handle(GetReplyQuery request, CancellationToken cancellationToken)
        {
            var reply = await _replyService.GetReplyByIdAsync(request.ReplyId);

            if (reply == null)
                throw new NotFoundException(nameof(Reply), request.ReplyId);

            var result = new ReplyViewModel
            {
                Id = reply.Id,
                Content = reply.Content,
                DateOfCreation = reply.DateOfCreation,
                PostId = reply.PostId
            };

            return result;
        }
    }
}
