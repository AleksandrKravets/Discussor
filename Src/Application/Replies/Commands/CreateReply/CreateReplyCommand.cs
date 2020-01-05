using MediatR;

namespace Application.Replies.Commands.CreateReply
{
    public class CreateReplyCommand : IRequest<int>
    {
        public string Content { get; set; }
        public int PostId { get; set; }
    }
}
