using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Replies.Queries.GetRepliesList
{
    public class RepliesListViewModel
    {
        public IEnumerable<ReplyDto> Replies { get; set; }
    }
}
