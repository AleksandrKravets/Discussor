using Discussor.Core.Application.Common.Contracts.Services;
using Discussor.Core.Application.Common.Exceptions;
using Discussor.Core.Domain.Entities;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Discussor.Core.Application.Posts.Queries.GetPost
{
    public class GetPostQueryHandler : IRequestHandler<GetPostQuery, PostViewModel>
    {
        private readonly IPostService _postService;
        private readonly IReplyService _replyService;

        public GetPostQueryHandler(
            IPostService postService,
            IReplyService replyService)
        {
            _postService = postService;
            _replyService = replyService;
        }

        public async Task<PostViewModel> Handle(GetPostQuery request, CancellationToken cancellationToken)
        {
            var post = await _postService.GetPostByIdAsync(request.PostId);

            if (post == null)
                throw new NotFoundException(nameof(Post), request.PostId);

            var replies =  _replyService.GetRepliesByPostId(request.PostId)
                .Select(reply => new ReplyDto
                {
                    Id = reply.Id,
                    Content = reply.Content,
                    DateOfCreation = reply.DateOfCreation,
                    Creator = new UserDto
                    {
                        Id = reply.Creator.Id,
                        NickName = reply.Creator.UserName
                    }
                }).ToList();

            var postCreator = new UserDto
            {
                Id = post.Creator.Id,
                NickName = post.Creator.UserName
            };

            var result = new PostViewModel
            {
                Id = post.Id,
                Title = post.Title,
                Content = post.Content,
                DateOfCreation = post.DateOfCreation,
                ThemeId = post.ThemeId,
                Replies = replies,
                Creator = postCreator
            };

            return result;
        }
    }
}
