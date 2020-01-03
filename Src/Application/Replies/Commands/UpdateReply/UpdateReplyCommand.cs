using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Replies.Commands.UpdateReply
{
    public class UpdateReplyCommand : IRequest
    {
        public int ReplyId { get; set; }
        public string Content { get; set; }
        public int PostId { get; set; }
    }
}
