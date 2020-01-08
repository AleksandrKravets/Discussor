using MediatR;

namespace Discussor.Core.Application.Themes.Queries.GetTheme
{
    public class GetThemeQuery : IRequest<ThemeViewModel>
    {
        public int ThemeId { get; set; }
    }
}
