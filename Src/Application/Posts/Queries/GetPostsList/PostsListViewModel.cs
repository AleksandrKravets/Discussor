using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Posts.Queries.GetPostsList
{
    public class PostsListViewModel
    {
        public IEnumerable<PostDto> Posts { get; set; }
    }
}
