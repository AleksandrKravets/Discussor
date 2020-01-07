using MediatR;

namespace Application.Themes.Commands.DeleteTheme
{
    public class DeleteThemeCommand : IRequest<bool>
    {
        public int ThemeId { get; set; }
    }
}
