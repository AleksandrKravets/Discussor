using System;

namespace Application.Posts.Queries.GetPostsList
{
    public class PostDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime DateOfCreation { get; set; }
        public int ThemeId { get; set; }
    }
}
