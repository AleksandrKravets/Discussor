using MediatR;

namespace Application.Posts.Commands.UpdatePost
{
    public class UpdatePostCommand : IRequest<bool>
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int ThemeId { get; set; } //
    }
}
