using Application.Common.Exceptions;
using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Replies.Commands.CreateReply
{
    public class CreateReplyCommandHandler : IRequestHandler<CreateReplyCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public CreateReplyCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateReplyCommand request, CancellationToken cancellationToken)
        {
            var post = _context.Posts.FindAsync(request.PostId);

            if (post == null)
                throw new NotFoundException(nameof(Post), request.PostId);

            var reply = new Reply
            {
                Content = request.Content,
                PostId = request.PostId,
                DateOfCreation = DateTime.Now
            };

            await _context.PostReplies.AddAsync(reply);

            await _context.SaveChangesAsync(cancellationToken);

            return reply.Id;
        }
    }
}
