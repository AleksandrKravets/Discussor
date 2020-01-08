using Discussor.Core.Application.Common.Contracts.Services;
using Discussor.Core.Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Discussor.Core.Application.Replies.Commands.UpdateReply
{
    public class UpdateReplyCommandHandler : IRequestHandler<UpdateReplyCommand, bool>
    {
        private readonly IReplyService _replyService;

        public UpdateReplyCommandHandler(IReplyService replyService)
        {
            _replyService = replyService;
        }

        public async Task<bool> Handle(UpdateReplyCommand request, CancellationToken cancellationToken)
        {
            var reply = new Reply
            {
                Id = request.ReplyId,
                Content = request.Content,
                DateOfCreation = DateTime.Now,
                PostId = request.PostId
            };

            return await _replyService.UpdateAsync(reply);
        }
    }
}
