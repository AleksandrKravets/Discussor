using MediatR;

namespace Discussor.Core.Application.Posts.Queries.GetPostsList
{
    public class GetPostsListQuery : IRequest<PostsListViewModel>
    {
        public int ThemeId { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }
}
