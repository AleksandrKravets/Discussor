using MediatR;

namespace Discussor.Core.Application.Themes.Commands.DeleteTheme
{
    public class DeleteThemeCommand : IRequest<bool>
    {
        public int ThemeId { get; set; }
    }
}
