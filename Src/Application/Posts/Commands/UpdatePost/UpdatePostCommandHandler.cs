using Discussor.Core.Application.Common.Contracts.Services;
using Discussor.Core.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Discussor.Core.Application.Posts.Commands.UpdatePost
{
    public class UpdatePostCommandHandler : IRequestHandler<UpdatePostCommand, bool>
    {
        private readonly IPostService _postService;

        public UpdatePostCommandHandler(IPostService postService)
        {
            _postService = postService;
        }

        public async Task<bool> Handle(UpdatePostCommand request, CancellationToken cancellationToken)
        {
            var post = new Post
            {
                Id = request.PostId,
                Content = request.Content,
                Title = request.Title,
                ThemeId = request.ThemeId
            }; 
            
            return await _postService.UpdateAsync(post);
        }
    }
}
