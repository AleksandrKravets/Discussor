using Discussor.Core.Domain.Entities;
using MediatR;

namespace Discussor.Core.Application.Replies.Commands.CreateReply
{
    public class CreateReplyCommand : IRequest<int>
    {
        public string Content { get; set; }
        public int PostId { get; set; }
        public string CreatorId { get; set; }
    }
}
