using Application.Common.Exceptions;
using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Replies.Queries.GetRepliesList
{
    public class GetRepliesListQueryHandler : IRequestHandler<GetRepliesListQuery, RepliesListViewModel>
    {
        private readonly IApplicationDbContext _context;

        public GetRepliesListQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<RepliesListViewModel> Handle(GetRepliesListQuery request, CancellationToken cancellationToken)
        {
            var post = await _context.Posts.FindAsync(request.PostId);

            if (post == null)
                throw new NotFoundException(nameof(Post), request.PostId);

            var replies = await _context.PostReplies
                .Where(reply => reply.PostId == request.PostId)
                .Select(reply => new ReplyDto
                {
                    Id = reply.Id,
                    Content = reply.Content,
                    DateOfCreation = reply.DateOfCreation,
                    PostId = reply.PostId
                }).ToListAsync();

            var result = new RepliesListViewModel
            {
                Replies = replies
            };

            return result;
        }
    }
}
