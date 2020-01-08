using Discussor.Core.Application.Common.Contracts.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Discussor.Core.Application.Posts.Commands.DeletePost
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
