using Application.Common.Exceptions;
using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Posts.Queries.GetPostsList
{
    public class GetPostsListQueryHandler : IRequestHandler<GetPostsListQuery, PostsListViewModel>
    {
        private readonly IApplicationDbContext _context;

        public GetPostsListQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<PostsListViewModel> Handle(GetPostsListQuery request, CancellationToken cancellationToken)
        {
            var theme = await _context.Themes.FindAsync(request.ThemeId);

            if (theme == null)
                throw new NotFoundException(nameof(Theme), request.ThemeId);

            var posts = await _context.Posts
                .Where(post => post.ThemeId == request.ThemeId)
                .Select(post => new PostDto
                {
                    Id = post.Id,
                    Title = post.Title,
                    Content = post.Content,
                    DateOfCreation = post.DateOfCreation,
                    ThemeId = post.ThemeId
                }).ToListAsync();

            var result = new PostsListViewModel
            {
                Posts = posts,
                ThemeId = request.ThemeId
            };

            return result;
        }
    }
}
