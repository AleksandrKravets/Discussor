using Application.Common.Exceptions;
using Application.Common.Models;
using Domain.Entities;
using Infrastructure.Contracts;
using Infrastructure.Identity;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
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

            var user = _context.Users.Find(post.UserId);

            if (user == null)
                throw new NotFoundException(nameof(User), post.UserId);

            var replies = await _context.PostReplies
                .Where(reply => reply.PostId == request.PostId)
                .Select(reply => new ReplyDto
                {
                    Id = reply.Id,
                    Content = reply.Content,
                    DateOfCreation = reply.DateOfCreation
                })
                .ToListAsync();


            var creator = new UserDto 
            {
                UserId = user.Id,
                Username = user.UserName
            };

            var result = new PostViewModel
            {
                Id = post.Id,
                Title = post.Title,
                Content = post.Content,
                DateOfCreation = post.DateOfCreation,
                ThemeId = post.ThemeId,
                Replies = replies,
                Creator = creator
            };

            return result;
        }
    }
}
