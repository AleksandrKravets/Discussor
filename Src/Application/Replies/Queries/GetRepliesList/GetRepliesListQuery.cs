using MediatR;

namespace Application.Replies.Queries.GetRepliesList
{
    public class GetRepliesListQuery : IRequest<RepliesListViewModel>
    {
        public int PostId { get; set; }
    }
}
