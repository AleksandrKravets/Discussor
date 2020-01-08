using MediatR;

namespace Discussor.Core.Application.Replies.Queries.GetRepliesList
{
    public class GetRepliesListQuery : IRequest<RepliesListViewModel>
    {
        public int PostId { get; set; }
    }
}
