using System.Collections.Generic;

namespace Discussor.Core.Application.Posts.Queries.GetPostsList
{
    public class PostsListViewModel
    {
        public IEnumerable<PostDto> Posts { get; set; }
        public int ThemeId { get; set; }
    }
}
