using Application.Common.Interfaces;
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
            var replies = await _context.PostReplies
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
