using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Posts.Queries.GetPost
{
    public class ReplyDto
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime DateOfCreation { get; set; }
    }
}
