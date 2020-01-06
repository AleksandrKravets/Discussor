using Application.Common.Exceptions;
using Domain.Entities;
using Infrastructure.Contracts;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Replies.Commands.UpdateReply
{
    public class UpdateReplyCommandHandler : IRequestHandler<UpdateReplyCommand>
    {
        private readonly IApplicationDbContext _context;

        public UpdateReplyCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateReplyCommand request, CancellationToken cancellationToken)
        {
            var reply = await _context.PostReplies.FindAsync(request.ReplyId);

            if (reply == null)
                throw new NotFoundException(nameof(Reply), request.ReplyId);

            reply.Content = request.Content;
            reply.DateOfCreation = DateTime.Now;

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
