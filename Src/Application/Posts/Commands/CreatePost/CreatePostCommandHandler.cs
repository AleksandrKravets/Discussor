using Discussor.Core.Application.Common.Contracts.Services;
using Discussor.Core.Application.Common.Exceptions;
using Discussor.Core.Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Discussor.Core.Application.Posts.Commands.CreatePost
{
    public class CreatePostCommandHandler : IRequestHandler<CreatePostCommand, int>
    {
        private readonly IPostService _postService;
        private readonly IThemeService _themeService;

        public CreatePostCommandHandler(IPostService postService, IThemeService themeService)
        {
            _postService = postService;
            _themeService = themeService;
        }

        public async Task<int> Handle(CreatePostCommand request, CancellationToken cancellationToken)
        {
            var theme = await _themeService.GetThemeByIdAsync(request.ThemeId);

            if (theme == null)
                throw new NotFoundException(nameof(Theme), request.ThemeId);

            var post = new Post
            {
                Title = request.Title,
                Content = request.Content,
                ThemeId = request.ThemeId,
                DateOfCreation = DateTime.Now,
                CreatorId = request.CreatorId
            };

            return await _postService.CreateAsync(post);
        }
    }
}
