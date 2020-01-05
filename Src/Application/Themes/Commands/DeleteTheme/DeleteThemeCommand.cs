using MediatR;

namespace Application.Themes.Commands.DeleteTheme
{
    public class DeleteThemeCommand : IRequest
    {
        public int ThemeId { get; set; }
    }
}
