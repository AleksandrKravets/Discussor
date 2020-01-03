using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Themes.Queries.GetThemesList
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
