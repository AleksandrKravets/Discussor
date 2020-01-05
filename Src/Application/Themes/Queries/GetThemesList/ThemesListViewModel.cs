using System.Collections.Generic;

namespace Application.Themes.Queries.GetThemesList
{
    public class ThemesListViewModel
    {
        public IEnumerable<ThemeDto> Themes { get; set; }
    }
}
