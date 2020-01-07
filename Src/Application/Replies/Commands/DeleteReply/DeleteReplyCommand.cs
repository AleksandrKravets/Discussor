using MediatR;

namespace Application.Replies.Commands.DeleteReply
{
    public class DeleteReplyCommand : IRequest<bool>
    {
        public int ReplyId { get; set; }
    }
}
