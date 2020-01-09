using System;

namespace Discussor.Core.Application.Themes.Queries.GetTheme
{
    public class ThemeViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime DateOfCreation { get; set; }
        public byte[] Image { get; set; }

        // добавить создателя
    }
}
