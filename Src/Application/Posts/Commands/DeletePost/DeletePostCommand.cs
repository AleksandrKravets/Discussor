using MediatR;

namespace Discussor.Core.Application.Posts.Commands.DeletePost
{
    public class DeletePostCommand : IRequest<bool>
    {
        public int PostId { get; set; }
    }
}
