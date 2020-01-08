using System;

namespace Discussor.Core.Application.Posts.Queries.GetPost
{
    public class ReplyDto
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime DateOfCreation { get; set; }
    }
}
