using MediatR;

namespace Application.Themes.Queries.GetTheme
{
    public class GetThemeQuery : IRequest<ThemeViewModel>
    {
        public int Id { get; set; }
    }
}
