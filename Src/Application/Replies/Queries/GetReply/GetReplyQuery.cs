using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Replies.Queries.GetReply
{
    public class GetReplyQuery : IRequest<ReplyViewModel>
    {
        public int ReplyId { get; set; }
    }
}
