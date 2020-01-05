using System.Collections.Generic;

namespace Application.Posts.Queries.GetPostsList
{
    public class PostsListViewModel
    {
        public IEnumerable<PostDto> Posts { get; set; }
        public int ThemeId { get; set; }
    }
}
