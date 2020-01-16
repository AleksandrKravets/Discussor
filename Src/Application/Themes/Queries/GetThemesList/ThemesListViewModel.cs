using System.Collections.Generic;

namespace Discussor.Core.Application.Themes.Queries.GetThemesList
{
    public class ThemesListViewModel
    {
        public IEnumerable<ThemeDto> Themes { get; set; }
        public int NumberOfAllThemes { get; set; }
    }
}
