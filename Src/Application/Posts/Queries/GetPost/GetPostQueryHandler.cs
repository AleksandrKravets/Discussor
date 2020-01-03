using Application.Common.Exceptions;
using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Posts.Queries.GetPost
{
    public class GetPostQueryHandler : IRequestHandler<GetPostQuery, PostViewModel>
    {
        private readonly IApplicationDbContext _context;

        public GetPostQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<PostViewModel> Handle(GetPostQuery request, CancellationToken cancellationToken)
        {
            var post = await _context.Posts.FindAsync(request.PostId);

            if (post == null)
                throw new NotFoundException(nameof(Post), request.PostId);

            var result = new PostViewModel
            {
                Id = post.Id,
                Title = post.Title,
                Content = post.Content,
                DateOfCreation = post.DateOfCreation,
                ThemeId = post.ThemeId
            };

            return result;
        }
    }
}
