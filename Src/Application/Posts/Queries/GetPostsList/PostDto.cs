using System;

namespace Discussor.Core.Application.Posts.Queries.GetPostsList
{
    public class PostDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime DateOfCreation { get; set; }
        public int ThemeId { get; set; }

        public UserDto Creator { get; set; }
    }
}
