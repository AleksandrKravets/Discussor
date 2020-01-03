using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Themes.Queries.GetThemesList
{
    public class ThemesListViewModel
    {
        public IEnumerable<ThemeDto> Themes { get; set; }
    }
}
