using Discussor.Core.Domain.Entities;
using MediatR;

namespace Discussor.Core.Application.Posts.Commands.CreatePost
{
    public class CreatePostCommand : IRequest<int>
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int ThemeId { get; set; }
        public string CreatorId { get; set; }
    }
}
