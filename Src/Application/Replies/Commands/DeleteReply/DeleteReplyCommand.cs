using MediatR;

namespace Application.Replies.Commands.DeleteReply
{
    public class DeleteReplyCommand : IRequest
    {
        public int ReplyId { get; set; }
    }
}
