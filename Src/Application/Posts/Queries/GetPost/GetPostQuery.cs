using MediatR;

namespace Application.Posts.Queries.GetPost
{
    public class GetPostQuery : IRequest<PostViewModel>
    {
        public int PostId { get; set; }
    }
}
