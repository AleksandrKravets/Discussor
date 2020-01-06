using Application.Common.Exceptions;
using Domain.Entities;
using Infrastructure.Contracts;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Posts.Commands.CreatePost
{
    public class CreatePostCommandHandler : IRequestHandler<CreatePostCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public CreatePostCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreatePostCommand request, CancellationToken cancellationToken)
        {
            var theme = await _context.Themes.FindAsync(request.ThemeId);

            if (theme == null)
                throw new NotFoundException(nameof(Theme), request.ThemeId);

            var post = new Post
            {
                Title = request.Title,
                Content = request.Content,
                DateOfCreation = DateTime.Now,
                ThemeId = request.ThemeId
            };

            await _context.Posts.AddAsync(post);

            await _context.SaveChangesAsync(cancellationToken);

            return post.Id;
        }
    }
}
