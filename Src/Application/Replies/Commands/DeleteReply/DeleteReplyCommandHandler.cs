using Application.Common.Exceptions;
using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Replies.Commands.DeleteReply
{
    public class DeleteReplyCommandHandler : IRequestHandler<DeleteReplyCommand>
    {
        private readonly IApplicationDbContext _context;

        public DeleteReplyCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(DeleteReplyCommand request, CancellationToken cancellationToken)
        {
            var reply = await _context.PostReplies.FindAsync(request.ReplyId);

            if (reply == null)
                throw new NotFoundException(nameof(Reply), request.ReplyId);

            _context.PostReplies.Remove(reply);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
