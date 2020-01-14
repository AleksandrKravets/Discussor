using Discussor.Core.Application.Common.Contracts.Services;
using Discussor.Core.Application.Common.Exceptions;
using Discussor.Core.Domain.Entities;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Discussor.Core.Application.Posts.Queries.GetPostsList
{
    public class GetPostsListQueryHandler : IRequestHandler<GetPostsListQuery, PostsListViewModel>
    {
        private readonly IPostService _postService;
        private readonly IThemeService _themeService;

        public GetPostsListQueryHandler(IPostService postService, IThemeService themeService)
        {
            _postService = postService;
            _themeService = themeService;
        }

        public async Task<PostsListViewModel> Handle(GetPostsListQuery request, CancellationToken cancellationToken)
        {
            var theme = await _themeService.GetThemeByIdAsync(request.ThemeId);

            if (theme == null)
                throw new NotFoundException(nameof(Theme), request.ThemeId);

            var posts = _postService.GetPostsByThemeId(request.ThemeId);
                var  p = posts.Where(post => post.ThemeId == request.ThemeId)
                .Select(post => new PostDto
                {
                    Id = post.Id,
                    Title = post.Title,
                    Content = post.Content,
                    DateOfCreation = post.DateOfCreation,
                    ThemeId = post.ThemeId,
                    Creator = new UserDto
                    {
                        Id = post.Creator.Id,
                        NickName = post.Creator.UserName
                    }

                }).ToList();

            var result = new PostsListViewModel
            {
                Posts = p, //
                ThemeId = request.ThemeId
            };

            return result;
        }
    }
}
