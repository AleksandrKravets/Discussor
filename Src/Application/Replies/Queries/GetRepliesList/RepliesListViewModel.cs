using System.Collections.Generic;

namespace Discussor.Core.Application.Replies.Queries.GetRepliesList
{
    public class RepliesListViewModel
    {
        public IEnumerable<ReplyDto> Replies { get; set; }
        public int PostId { get; set; }
    }
}
