﻿using Application.Common.Exceptions;
using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Posts.Commands.DeletePost
{
    public class DeletePostCommandHandler : IRequestHandler<DeletePostCommand>
    {
        private readonly IApplicationDbContext _context;

        public DeletePostCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(DeletePostCommand request, CancellationToken cancellationToken)
        {
            var post = await _context.Posts.FindAsync(request.PostId);

            if (post == null)
                throw new NotFoundException(nameof(Post), request.PostId);

            _context.Posts.Remove(post);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}