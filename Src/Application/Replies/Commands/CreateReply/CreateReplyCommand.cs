using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Replies.Commands.CreateReply
{
    public class CreateReplyCommand : IRequest<int>
    {
        public string Content { get; set; }
        public int PostId { get; set; }
    }
}
