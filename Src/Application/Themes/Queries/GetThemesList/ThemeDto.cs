using System;

namespace Discussor.Core.Application.Themes.Queries.GetThemesList
{
    public class ThemeDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime DateOfCreation { get; set; }
        public byte[] Image { get; set; }
        public int PostsNumber { get; set; }
    }
}
