using Discussor.Core.Application.Common.Contracts.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Replies.Commands.DeleteReply
{
    public class DeleteReplyCommandHandler : IRequestHandler<DeleteReplyCommand, bool>
    {
        private readonly IReplyService _replyService;

        public DeleteReplyCommandHandler(IReplyService replyService)
        {
            _replyService = replyService;
        }

        public async Task<bool> Handle(DeleteReplyCommand request, CancellationToken cancellationToken)
        {
            return await _replyService.DeleteAsync(request.ReplyId);
        }
    }
}
