using System;

namespace Discussor.Core.Application.Replies.Queries.GetRepliesList
{
    public class ReplyDto
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime DateOfCreation { get; set; }
        public int PostId { get; set; }
    }
}
