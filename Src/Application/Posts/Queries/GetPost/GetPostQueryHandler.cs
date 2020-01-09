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
        private readonly IUserService _userService;

        public GetPostQueryHandler(
            IPostService postService,
            IReplyService replyService,
            IUserService userService)
        {
            _postService = postService;
            _replyService = replyService;
            _userService = userService;
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
                        Id = reply.UserId,
                        UserName = _userService.GetUserByIdAsync(reply.UserId).Result.UserName
                    }
                }).ToList();

            var postCreator = new UserDto
            {
                Id = post.UserId,
                UserName = (await _userService.GetUserByIdAsync(post.UserId)).UserName ?? "lox"
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
