using Discussor.Core.Application.Common.Contracts.Services;
using Discussor.Core.Application.Common.Exceptions;
using Discussor.Core.Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Discussor.Core.Application.Replies.Commands.CreateReply
{
    public class CreateReplyCommandHandler : IRequestHandler<CreateReplyCommand, int>
    {
        private readonly IPostService _postService;
        private readonly IReplyService _replyService;

        public CreateReplyCommandHandler(IPostService postService, IReplyService replyService)
        {
            _postService = postService;
            _replyService = replyService;
        }

        public async Task<int> Handle(CreateReplyCommand request, CancellationToken cancellationToken)
        {
            var post = await _postService.GetPostByIdAsync(request.PostId);

            if (post == null)
                throw new NotFoundException(nameof(Post), request.PostId);

            var reply = new Reply
            {
                Content = request.Content,
                PostId = request.PostId,
                DateOfCreation = DateTime.Now
            };

            return await _replyService.CreateAsync(reply);
        }
    }
}
