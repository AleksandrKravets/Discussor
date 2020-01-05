using MediatR;

namespace Application.Replies.Commands.UpdateReply
{
    public class UpdateReplyCommand : IRequest
    {
        public int ReplyId { get; set; }
        public string Content { get; set; }
        public int PostId { get; set; }
    }
}
