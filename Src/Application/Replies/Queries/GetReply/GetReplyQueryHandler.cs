using Application.Common.Exceptions;
using Domain.Entities;
using Infrastructure.Contracts;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Replies.Queries.GetReply
{
    public class GetReplyQueryHandler : IRequestHandler<GetReplyQuery, ReplyViewModel>
    {
        private readonly IApplicationDbContext _context;

        public GetReplyQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ReplyViewModel> Handle(GetReplyQuery request, CancellationToken cancellationToken)
        {
            // request.PostId == reply.PostId
            var reply = await _context.PostReplies.FindAsync(request.ReplyId);

            if (reply == null)
                throw new NotFoundException(nameof(Reply), request.ReplyId);

            var result = new ReplyViewModel
            {
                Id = reply.Id,
                Content = reply.Content,
                DateOfCreation = reply.DateOfCreation,
                PostId = reply.PostId
            };

            return result;
        }
    }
}
