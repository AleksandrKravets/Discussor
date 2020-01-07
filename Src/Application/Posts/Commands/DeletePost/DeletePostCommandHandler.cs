using Discussor.Core.Application.Common.Contracts.Services;
using Discussor.Core.Application.Common.Exceptions;
using Discussor.Core.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Posts.Commands.DeletePost
{
    public class DeletePostCommandHandler : IRequestHandler<DeletePostCommand, bool>
    {
        private readonly IPostService _postService;

        public DeletePostCommandHandler(IPostService postService)
        {
            _postService = postService;
        }
        
        public async Task<bool> Handle(DeletePostCommand request, CancellationToken cancellationToken)
        {
            return await _postService.DeleteAsync(request.PostId);
        }
    }
}
