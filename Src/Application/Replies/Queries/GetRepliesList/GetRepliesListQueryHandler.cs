using Discussor.Core.Application.Common.Contracts.Services;
using Discussor.Core.Application.Common.Exceptions;
using Discussor.Core.Domain.Entities;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Discussor.Core.Application.Replies.Queries.GetRepliesList
{
    public class GetRepliesListQueryHandler : IRequestHandler<GetRepliesListQuery, RepliesListViewModel>
    {
        private readonly IPostService _postService;
        private readonly IReplyService _replyService;

        public GetRepliesListQueryHandler(IPostService postService, IReplyService replyService)
        {
            _postService = postService;
            _replyService = replyService;
        }

        public async Task<RepliesListViewModel> Handle(GetRepliesListQuery request, CancellationToken cancellationToken)
        {
            var post = await _postService.GetPostByIdAsync(request.PostId);

            if (post == null)
                throw new NotFoundException(nameof(Post), request.PostId);

            var replies = _replyService.GetRepliesByPostId(request.PostId)
                .Select(reply => new ReplyDto
                {
                    Id = reply.Id,
                    Content = reply.Content,
                    DateOfCreation = reply.DateOfCreation,
                    PostId = reply.PostId,
                    Creator = new UserDto
                    {
                        Id = reply.Id,
                        NickName = reply.Creator.UserName
                    }
                }).ToList();

            var result = new RepliesListViewModel
            {
                Replies = replies,
                PostId = request.PostId
            };

            return result;
        }
    }
}
