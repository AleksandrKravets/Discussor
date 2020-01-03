using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Replies.Commands.DeleteReply
{
    public class DeleteReplyCommand : IRequest
    {
        public int ReplyId { get; set; }
    }
}
