using MediatR;

namespace Application.Posts.Commands.CreatePost
{
    public class CreatePostCommand : IRequest<int>
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int ThemeId { get; set; }
    }
}
