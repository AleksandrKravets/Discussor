using MediatR;

namespace Application.Replies.Queries.GetReply
{
    public class GetReplyQuery : IRequest<ReplyViewModel>
    {
        public int ReplyId { get; set; }
    }
}
