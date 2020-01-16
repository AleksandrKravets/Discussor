using MediatR;

namespace Discussor.Core.Application.Posts.Queries.GetPost
{
    public class GetPostQuery : IRequest<PostViewModel>
    {
        public int PostId { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }
}
