using MediatR;

namespace Discussor.Core.Application.Replies.Commands.DeleteReply
{
    public class DeleteReplyCommand : IRequest<bool>
    {
        public int ReplyId { get; set; }
    }
}
