using MediatR;

namespace Application.Posts.Commands.DeletePost
{
    public class DeletePostCommand : IRequest<bool>
    {
        public int PostId { get; set; }
    }
}
